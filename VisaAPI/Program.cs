var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");  // use this as the db url when using docker 
// var databaseUrl = "Host=localhost;Port=5000;Database=dcodeDB;Username=postgres;Password=123;";

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AuthAPIContext>(
    options => options.UseNpgsql(databaseUrl)
);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
