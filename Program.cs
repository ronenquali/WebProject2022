var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Goodbye World!!!");

app.MapGet("/time", () => DateTime.Now.ToLongTimeString());
app.MapGet("/date", () => DateTime.Now.ToLongDateString());

app.Run();
