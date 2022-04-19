var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Goodbye World!!!");
app.MapGet("/date", () => DateTime.Now.ToLongDateString());
//failed change? whaaaa?
//how about now?

app.Run();
