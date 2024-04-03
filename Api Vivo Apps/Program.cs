using AutoMapper;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.OpenApi.Models;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Shared_Class_Vivo_Apps.Model_DTO;
using Swashbuckle.AspNetCore.SwaggerGen;
using Vivo_Apps_API;
using Vivo_Apps_API.Controllers;
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

builder.Services.AddDistributedSqlServerCache(options =>
{
    options.ConnectionString = "Data Source=10.124.100.153;Initial Catalog=Vivo_MAIS;TrustServerCertificate=True;User ID=RegionalNE;Password=RegionalNEvivo2019";
    options.SchemaName = "dbo";
    options.TableName = "API_CACHE";
});

builder.Services.AddSignalR();
builder.Services.AddHttpClient();
builder.Services.AddHttpLogging(o => o = new Microsoft.AspNetCore.HttpLogging.HttpLoggingOptions());
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.IgnoreNullValues = true;
});

//builder.Services.AddSingleton<TableDependencyService>();

builder.Services.AddDbContext<VICContext>(opt => {
    opt.EnableSensitiveDataLogging();
    opt.EnableDetailedErrors();
}, ServiceLifetime.Singleton);

builder.Services.AddDbContext<Vivo_MaisContext>(opt =>
{
    opt.EnableSensitiveDataLogging();
    opt.EnableDetailedErrors();
}, ServiceLifetime.Scoped);

builder.Services.AddDbContextFactory<DemandasContext>(opt =>
{
    opt.EnableSensitiveDataLogging();
    opt.EnableDetailedErrors();
}, ServiceLifetime.Singleton);
 
builder.Services.AddSingleton<ISuporteDemandaHub, SuporteDemandaHub>();

var app = builder.Build();

app.Lifetime.ApplicationStarted.Register(async () =>
{
    //var currentTimeUTC = DateTime.UtcNow.ToString();
    //byte[] encodedCurrentTimeUTC = System.Text.Encoding.UTF8.GetBytes(currentTimeUTC);
    //var options = new DistributedCacheEntryOptions()
    //    .SetSlidingExpiration(TimeSpan.FromSeconds(20));

    //app.Services.GetService<IDistributedCache>()
    //.Set("cachedTimeUTC", encodedCurrentTimeUTC, options);

    await app.Services.GetRequiredService<ISuporteDemandaHub>()
    .SendTableDemandas();
});

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
    app.MapHub<SuporteDemandaHub>("/Suportehub/{matricula}/{regional}");
    app.MapHub<SuporteDemandaHub>("/Suportehub/{matricula}/{regional}/{demandaid}");
    app.MapHub<SuporteDemandaHub>("/Suportehub");
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