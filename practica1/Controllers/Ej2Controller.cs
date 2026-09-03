// Por favor, ignore mis anotaciones, me sirven para tomar notas
using Microsoft.AspNetCore.Mvc;
using practica1.Ej2;  

namespace practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  //Un decorador que declara la ruta? supongo.
    public class Ej2Controller : ControllerBase
    {
        private static List<PhotoBook> _albums = new List<PhotoBook>(); // Esto debe imitar una base de datos al usar una propiedad estática
        private static int _nextId = 1; // Y esto obviamente es el contador del id. Debe ser convención de C# escribir los métodos y propiedades privados con un _ antes del nombre.

        public class CreateAlbumRequest // Un DTO porque resultó más fácil así.
        {
            public int? numPages {get;set;}
        }

        [HttpPost("standard")]
        public IActionResult CreateStandardAlbum([FromBody] CreateAlbumRequest request) // Esta sintaxis para anunciar el parámetro de request es rarísima. Si la diseccionamos, declara un método de tipo 'IActionResult' (no era para interfaces la sintaxis de I+PascalCase? Es IActionResult un tipo específico de interfaz que viene por AspNetCore.mvc?); este método/interfaz toma por parámetro un decorador '[FromBody]' que debe indicar que el parámetro viene en el body de la req (podemos asumir que si se emplea [FromHead] o [FromHeader] se pueden extraer también datos de la cabecera de la request?), y el parámetro en típico 'tipo+nombre' de los lenguajes tipados, donde por convención debe llamarse 'request' y ser un objeto de clase DTO creada específicamente para esta función.
        {
            PhotoBook album;

            if (request.numPages.HasValue)
            {
                album = new PhotoBook(request.numPages.Value);
            }
            else
            {
                album = new PhotoBook();
            }

            album.id = _nextId++;
            _albums.Add(album);

            return Ok(album);
        }


        [HttpPost("big")]
        public IActionResult CreateBigAlbum()
        {
            var album = new BigPhotoBook();
            album.id = _nextId++;
            _albums.Add(album);

            return Ok(album);
        }
        


        [HttpGet("{id}")]
        public IActionResult GetAlbumById(int id)
        {
            var album = _albums.FirstOrDefault(a => a.id == id);

            if (album == null)
            {
                return NotFound($"No se encontró un álbum con Id {id}.");
            }

            return Ok(album);
        }
        

        [HttpGet]
        public IActionResult GetAllAlbums()
        {
            return Ok(_albums);
        }
    }
}