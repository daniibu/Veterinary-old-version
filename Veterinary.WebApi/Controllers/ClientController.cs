using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinary.Infrastructure.Repositories;
using Veterinary.Core.Entities;
using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;
using Veterinary.Core.DTOs;
using System.Reflection.Metadata.Ecma335;
using Veterinary.Infraestructure.Services;

namespace Veterinary.WebApi.Controllers
{
    //Este decorador indica a la página web cómo acceder a este controlador. Si desde una pagina quiero acceder a este controlador
    //debo escribir https:// el nombre del servidor/api(No es obligatorio poner api, se puede poner cualquiera)/nombre del controlador. 
    //El navegador sabrá cual es el nombre del controlador porque será el nombre de la clase pero sin el nombre controller.
    //Por eso debe estar bien escrito y seguido de 'controller'
    [Route("api/[controller]")]
    //Este decorador dice que esta clase será utilizada como controlador api y por lo tanto agrega ciertas herramientas
    //que permiten manejarlo como un web api, son los distintos request que se pueden ejecutar en html, comp get, put, post, etc.
    //Si se quita no se podrán utilzar las sentencias get, put, post, etc.
    [ApiController]
    //Acá se usan métodos de petición.
    //ControllerBase es la clase que me provee todos los metodos necesarios para utilizar la clase como un controlador.
    public class ClientController : ControllerBase
    {
        //Aca ya no se usa el contexto, esto lo usa el repositorio ya. Porque si se cambia la base de datos, en lugar
        //de tener que cambiar el controlador se cambia el repositorio. Uso inyección de dependencias porque las interfaces
        //no dicen como usar el codigo, sino que hacer. 

        //Declaro la inyección de dependencias:
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        //Get para obtener datos del servidor.
        [HttpGet]

        //Devolverá el resultado de una acción .
        public async Task<ActionResult<IEnumerable<ClientFullDto>>> GetClientList()
        {
            var clients = await _clientRepository.GetAll();
            return Ok(clients);
        }
        //[HttpGet ("{clientName:string}")]
        //El [HttpPut("{id}")] hace un update.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientFullDto(int id, Client client)
        {
            //Al usar los DTO hay que hacer un mapeo dentro de este if. Para asegurarse de que el id que está mandando sea igual al que está en el cuerpo del mensaje.
            if (id != client.clientId)
            {
                return BadRequest();
            }
            //Si el id corresponde, ahora si hago el mapeo.
            try
            {
                await clientRepository.SaveClient(client);
            }
        }
        //Esto determina si el dato es nuevo o solo se va a modificar.
        public async Task SaveClient(ClientFullDto client)
        {
            if (client.clientId > 0)
            {

            }
        }
    }
}
