using Microsoft.AspNetCore.Mvc;
using practica1.Ej1;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get(
        [FromQuery] string nombre1,
        [FromQuery] string nombre2,
        [FromQuery] string nombre3)
    {
        Persona persona1 = new Persona(nombre1);
        Persona persona2 = new Persona(nombre2);
        Persona persona3 = new Persona(nombre3);

        return new List<string>
        {
            persona1.GetSaludo(),
            persona2.GetSaludo(),
            persona3.GetSaludo()
        };
    }
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("Hello, World");
    }
}