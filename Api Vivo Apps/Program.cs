using Vivo_Apps_API;
using Vivo_Apps_API.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSignalR();
builder.Services.AddHttpClient();
//builder.Services.AddSingleton<TableDependencyService>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
if (app.Environment.IsDevelopment())
{
}

// Configure the HTTP request pipeline.
//app.UseAuthentication();
//app.UseAuthorization();
app.MapControllers();
app.UseHttpLogging();

app.UseRouting();
app.UseFileServer();
//app.UseEndpoints(endpoints =>
//{
//    app.MapHub<VivoXHub>("/vivoxhub");
//});
//app.Services.GetRequiredService<TableDependencyService>();
app.Run();
