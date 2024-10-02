using AutoMapper;
using Shared_Razor_Components.Services;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.OpenApi.Models;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using Shared_Static_Class.Model_DTO;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.Json;
using System.Text;
using Vivo_Apps_API;
using Vivo_Apps_API.Controllers;
using Vivo_Apps_API.Hubs;
using Microsoft.Net.Http.Headers;
using DocumentFormat.OpenXml.InkML;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;
using Shared_Static_Class.Converters;
using Shared_Static_Class.Data;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//builder.AddServiceDefaults();

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(20);
    serverOptions.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(20);
});

// Add services to the container. 

//builder.Services.AddControllers().AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.Converters.Add(new Iso8601DateTimeConverter());
//});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Vivo Apps API",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Email = "ne_automacao.br@telefonica.com",
            Name = "Automação NE",
            Url = new Uri("mailto:ne_automacao.br@telefonica.com")
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


//builder.Services.AddSingleton<TableDependencyService>();

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

builder.Services.AddDbContextFactory<CardapioDigitalContext>(opt =>
{
    opt.EnableSensitiveDataLogging();
    opt.EnableDetailedErrors();
}, ServiceLifetime.Singleton);

builder.Services.AddSingleton<ISuporteDemandaHub, SuporteDemandaHub>();
builder.Services.AddSingleton<IPWService, PWService>();

builder.Services.AddOutputCache(options =>
{
    options.AddPolicy("CacheForTenSeconds", builder =>
    {
        builder.Cache();
        builder.Expire(TimeSpan.FromSeconds(10));
        builder.Tag("another-tag");
    });
});

var app = builder.Build();

//app.MapDefaultEndpoints();

app.Lifetime.ApplicationStarted.Register(async () =>
{
    //var currentTimeUTC = DateTime.UtcNow.ToString();
    //byte[] encodedCurrentTimeUTC = System.Text.Encoding.UTF8.GetBytes(currentTimeUTC);
    //var options = new DistributedCacheEntryOptions()
    //    .SetSlidingExpiration(TimeSpan.FromSeconds(20));

    //app.Services.GetService<IDistributedCache>()
    //.Set("cachedTimeUTC", encodedCurrentTimeUTC, options);

    //await app.Services.GetRequiredService<ISuporteDemandaHub>().GetAllAsync(null);
});

app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
}
// Configure the HTTP request pipeline.
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpLogging();

app.UseRouting();
app.UseFileServer();
app.UseRouting();
app.UseOutputCache();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    app.MapHub<VivoXHub>("/vivoxhub/{PDV}/{idBoleta}");
    app.MapHub<VivoXHub>("/vivoxhub/{PDV}");
    app.MapHub<SuporteDemandaHub>("/Suportehub/{matricula}/{regional}");
    app.MapHub<SuporteDemandaHub>("/Suportehub/{matricula}/{regional}/{role}");
    app.MapHub<SuporteDemandaHub>("/Suportehub/{matricula}/{regional}/{role}/{demandaid}");
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
public class Iso8601DateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && DateTime.TryParse(reader.GetString(), out var dateTime))
            return dateTime;
        throw new JsonException("Invalid DateTime format");
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
}