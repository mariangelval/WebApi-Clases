# C#

Crear e inicializar un proyecto
````
dotnet new webapi -n Api
````
- Se van a crear muchos archivos entre esos el Program.cs donde tenemos que programar nosotros. Hay que borrar ciertas líneas de código que están de ejemplo

Para correr el proyecto
````
dotnet run
````
- Nos va a salir una pagina vacía http://localhost:5124 y le tenemos que agregar /swagger, que nos da uina interfaz de usuario para poder ver nuestro programa y sus endpoints. 

### Notas
#### Métodos HTTP 
- Get --> **mostrar** listado de alumnos
- Post --> **crear** un alumno
- Put --> **actualizar** alumno
- Delete --> **Borrar** un alumno