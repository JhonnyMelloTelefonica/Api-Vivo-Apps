using AutoMapper;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;
using Vivo_Apps_API;
using Vivo_Apps_API.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
