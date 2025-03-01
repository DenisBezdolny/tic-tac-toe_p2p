

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR(); // Добавляем SignalR

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "P2P TicTacToe API v1");
        c.RoutePrefix = "swagger";
    });
}

app.UseRouting();
app.UseDefaultFiles();  // Раздаёт index.html по умолчанию
app.UseStaticFiles();   // Раздаёт статические файлы из wwwroot


app.Run();
