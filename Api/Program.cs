using Application;

var builder = WebApplication.CreateBuilder(args);

// Config
var configuration = builder.Configuration.AddDomainConfig();

// Add services to the container.
builder.Services.AddDomainServices();
builder.Services.AddHttpClient("Products", httpClient =>
{
  var baseUrl = configuration.Build()["Secrets:ApiBaseUrl"];
  httpClient.BaseAddress = new Uri(baseUrl!);
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
