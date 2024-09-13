using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args); // se crea el objeto biulder, guarda las config necesarias para que el proyecto se contruya

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // genera el swagger

var app = builder.Build(); // le decimos al método que contruya

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // si estás es modo desarrollo puede ver la pantalla swagger de endpoints, de lo contrario se ejecuta en modo realease
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Esto lo agrego yoo, endpoint
app.MapGet("/", () =>{
    return Results.Ok("hola mundo");
});

app.MapPost("/", ([FromBody] string nombre)=> {
    return Results.Ok(nombre);
});

app.Run();
