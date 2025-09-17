var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! - Trịnh Văn Chung - 2200012122");

app.Run();
