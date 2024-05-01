using Serilog;
using Serilog.Sinks.Udp.TextFormatters;
using System.Net.Sockets;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Udp(
        "localhost",
        7071,
        AddressFamily.InterNetwork,
        new Log4jTextFormatter())
    .WriteTo.Debug()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run("http://+:5000");