using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;

using Veterinaria.Services.Owners;
using Veterinaria.Services.Pets;
using Veterinaria.Services.Quotes;
using Veterinaria.Services.Vets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Agregamos los controladores de los servicios 
builder.Services.AddControllers();
builder.Services.AddCors(Options => {
    Options.AddPolicy("AllowAnyOrigin",
    builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

//Agreamos los servicios de MYsql
builder.Services.AddDbContext<VeterinariaContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

//Agregamos la interfaz y el repository
builder.Services.AddScoped <IOwnersRepository, OwnersRepository>();
builder.Services.AddScoped<IPetsRepository , PetsRepository>();
builder.Services.AddScoped<IQuotesRepository , QuotesRepository>();
builder.Services.AddScoped<IVetsRepository , VetsRepository>();

//permisos para el fetch

var app = builder.Build();
app.UseCors("AllowAnyOrigin");
app.MapControllers();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();



app.Run();

