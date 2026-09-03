using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using practica1.Ej3;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]


public class Ej3Controller : ControllerBase
{
    private List<Estudiante> _estudiantes = new();
    private List<Profesor> _profesores = new();
// voy a copiar las consignas

// Crear una nueva Persona y hacer que diga hola
    [HttpPost("estudiante")]
    public IActionResult EstudianteDummy()
    {
        var estudianteNuevo = new Estudiante();
        _estudiantes.Add(estudianteNuevo);
        return Ok(estudianteNuevo.Saludar());
    }

// Crear un nuevo Estudiante, establecer una edad, retornar el saludo y su edad.
    [HttpPost("estudiante/{name}+{age}")]
    public IActionResult EstudianteNuevo(string name, int age)
    {
        var estudianteNuevo = new Estudiante(age, name);
        _estudiantes.Add(estudianteNuevo);
        return Ok($"{estudianteNuevo.Saludar()}\n{estudianteNuevo.MostrarEdad()}");
    }

// Crear un nuevo Profesor, establecer una edad, retornar el saludo y la explicación.
    [HttpPost("profesor/{name}+{age}")]
    public IActionResult ProfesorNuevo(string name, int age)
    {
        var profesorNuevo = new Profesor(age, name);
        _profesores.Add(profesorNuevo);
        return Ok($"{profesorNuevo.Saludar()}\n{profesorNuevo.Explicar()}");
    }
}