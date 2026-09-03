using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using practica1.Ej4;

namespace practica1.Controllers;

[ApiController]
[Route("[controller]")]


public class Ej4Controller : ControllerBase
{
    private static List<IVehiculo> _Autos = new();

    [HttpPost("coche")]
    public IActionResult CrearCoche ([FromQuery] int combustible)
    {
        var cocheNuevo = new Coche(combustible);
        _Autos.Add(cocheNuevo);
        return Ok(cocheNuevo.Conducir());
    }

    [HttpPatch("coche/{id}")]
    public IActionResult CargarCombustible(int id, [FromQuery] int combustible)
    {
        var cocheNuevo = _Autos.FirstOrDefault(a => a.Id() == id );
        if (cocheNuevo is null) 
        {
            return NotFound("No se encontró un auto con ese Id.");
        };
        cocheNuevo.CargarCombustible(combustible);
        return Ok(cocheNuevo.Conducir());
    }

    [HttpGet("coche")]
    public IActionResult MostrarAutos()
    {
        if (_Autos is null || _Autos.Count()<1) {return NotFound("No hay autos.");}
        else {return Ok(_Autos);}
        
    }
    public IActionResult MostrarAutoPorId([FromQuery] int id)
    {
        var cocheEncontrado = _Autos.FirstOrDefault(a => a.Id() == id );
        if (cocheEncontrado is null) 
        {
            return NotFound("No se encontró un auto con ese Id.");
        }
        else {return Ok(cocheEncontrado);}
    }
}