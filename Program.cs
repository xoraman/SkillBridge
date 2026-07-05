using skillbridge.Business.Dependency;
using skillbridge.Data.Dependency;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataServices(builder.Configuration);
builder.Services.AddBusinessServices();
var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();



app.UseDefaultFiles();
app.UseStaticFiles();
app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapFallbackToFile("index.html");

app.UseDefaultFiles();
app.UseStaticFiles();


app.Run();
