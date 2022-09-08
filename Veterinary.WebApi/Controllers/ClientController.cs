using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinary.Core.DTOs;
using Veterinary.Core.Entities;
using Veterinary.Infraestructure.Services;
using Veterinary.Infrastructure.Data;

namespace Veterinary.WebApi.Controllers
{   
    [ApiController]//esta clase va a ser utilizada como coontrolador api, me va a agregar ciertar erramientas para manejarlo como un web api: esos son los distintos tipos de rescues para ejecutar en html
    //html controla varias sentencias para obtener,modificar, etc de una página
    //esas sentencias la da el apiController
    //Acá se usan métodos de petición.
    [Route("api/[controller]")] //Decorador:le dice aASP.net, para acceder a esta clase es escribiendo
    //en el navegador el nombre del servidor
    //le va a indicar a la pagina web como acceder a este controlador, mediante el enlace que quiere acceder a a la api debo de escribir el html://normbreservidor/api y el nombre del controlador
    //como sabe quien es el nombre del controlador? mira la clase que debe heredar de la clase controllerbase, y el nombre del controlador sera el nombre de la clase sin el controller
    //no es obligatorio opner el  nombre api, lo va a tomar como la ruta del controlador, esa es la url a la cual voy a acceder al controlador

    public class ClientController : ControllerBase//es la clase que me provee los metodos necesarioas para usar esta clase como controlador
        //cuando armamos la estructura vamos a tener una vista, que tendra conotroladores, y estos se comunican con el enlace de datos y se comunica con la base de datos, y viceversa
        //los repositorios estan del lado del servidor
    {
        //ya no vamos a usar contexto,vamos a usar los repositorios
        // private readonly VeterinaryContext? context;

        //esto se hace por si cambio la base de datos, en vez de cambiar el controlador,cambio el repositorio

        //inyeccion de dependencia aquí
        private readonly IClientRepository _clientRepository;
        
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;//this esta hablando de la clase
        }

        //Get para obtener datos del servidor.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientFullDto>>> GetClientList()
        {
            var clients = await _clientRepository.GetClientId();
            return Ok(clients);
            
        }
        //Este es para que me devuelva un solo cliente, este httpget espera un id, el cliente que coincida con este id:
        [HttpGet("[id:int]")]
        public async Task<ActionResult<ClientFullDto>> GetClient(int id)
        {
            
        }
        //Post para enviar datos al servidor.
        [HttpPost]
        //Este es un mapeo inverso, esto del DTO lo paso a la entidad.s
        public async Task<ActionResult<Client>> SaveClient(ClientFullDto client)
        {
            
        }
    }   
}
