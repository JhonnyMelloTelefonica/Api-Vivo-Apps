using AutoMapper;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.OpenApi.Models;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Swashbuckle.AspNetCore.SwaggerGen;
using Vivo_Apps_API;
using Vivo_Apps_API.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Vivo Apps API", Version = "v1", 
        Contact = new OpenApiContact { 
            Email = "ne_automacao.br@telefonica.com", Name = "Automação NE", Url = new Uri("mailto:ne_automacao.br@telefonica.com") 
        } 
    });

    // Customize operationId to be equal to the route name
    c.CustomOperationIds(apiDesc =>
    {
        return apiDesc.RelativePath?.Split('/')[2] ?? null;
    });

    c.DocumentFilter<CustomDocumentFilter>();
});

builder.Services.AddSignalR();
builder.Services.AddHttpClient();
builder.Services.AddHttpLogging(o => o = new Microsoft.AspNetCore.HttpLogging.HttpLoggingOptions());
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.IgnoreNullValues = true;
});

builder.Services.AddDbContext<Vivo_MaisContext>(opt =>
{
    opt.EnableSensitiveDataLogging();
    opt.EnableDetailedErrors();
});


//builder.Services.AddSingleton<TableDependencyService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
}


// Configure the HTTP request pipeline.
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseHttpLogging();

app.UseRouting();
app.UseFileServer();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    app.MapHub<VivoXHub>("/vivoxhub/{PDV}/{idBoleta}");
    app.MapHub<VivoXHub>("/vivoxhub/{PDV}");
});
//app.Services.GetRequiredService<TableDependencyService>();
app.Run();


public class CustomDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        foreach (var pathItem in swaggerDoc.Paths)
        {
            foreach (var operation in pathItem.Value.Operations)
            {
                // Set summary to be equal to the route name
                operation.Value.Summary = pathItem.Key.Split('/')[3];
            }
        }
    }
}