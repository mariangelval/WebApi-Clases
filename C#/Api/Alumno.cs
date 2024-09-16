namespace Api;
public class Alumno
{
    public int Id {get; set;}
    public required string Nombre {get; set;}
    public int Edad {get; set;}
    public List<Curso> cursos = new List<Curso>();
}