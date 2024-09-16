using Microsoft.AspNetCore.Mvc;
using Api;

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
List<Alumno> alumnos = [
    new Alumno{Id = 1, Nombre = "Vani"},
    new Alumno{Id = 2, Nombre = "Mari"},
    new Alumno{Id = 3, Nombre = "Ili"}
];

app.UseHttpsRedirection();

//Esto lo agrego yoo, endpoint
app.MapGet("/", () =>{
    return Results.Ok("hola mundo");
});

app.MapPost("/", ([FromBody] string nombre)=> {
    return Results.Ok(nombre);
});

// lee el lsitado de alumnos
app.MapGet("/alumno", () => 
{
    return Results.Ok(alumnos);
});

// crea un nuevo alumno en la lista
app.MapPost("/alumno", ([FromBody] Alumno alumno) =>{
    alumnos.Add(alumno);
    return Results.Ok(alumnos);
});

//borrar un alumno de la lista
app.MapDelete("/alumno", ([FromQuery] int idAlumno) => {
    Alumno alumnoAEliminar = alumnos.FirstOrDefault(alumno => alumno.Id == idAlumno); //Este metodo busca el alumno, si no lo ecuentra devuelve null
    //Si encuentro el alumno lo elimino
    if(alumnoAEliminar != null)
    {
        alumnos.Remove(alumnoAEliminar);
        return Results.Ok(alumnos); //Código 200
    }
    //Si no, se marca como no encontrado
    else
    {
        return Results.NotFound(); //Código 404
    }
});

//Actualizar alumno
app.MapPut("/alumno", ([FromQuery] int idAlumno, [FromBody] Alumno alumno)=>{
    var alumnoAActualizar = alumnos.FirstOrDefault(alumno => alumno.Id == idAlumno);
    if(alumnoAActualizar.Nombre !=  null)
    {
        alumnoAActualizar.Nombre = alumno.Nombre;
        return Results.Ok(alumnos); //Codigo 200
    }
    else
    {
        return Results.NotFound(); //Código 404
    }
});

// ------------------ CURSOS ----------------------

app.Run();
