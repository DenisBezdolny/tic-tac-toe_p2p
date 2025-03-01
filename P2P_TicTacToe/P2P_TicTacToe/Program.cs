

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR(); // ��������� SignalR

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
app.UseDefaultFiles();  // ������ index.html �� ���������
app.UseStaticFiles();   // ������ ����������� ����� �� wwwroot


app.Run();
