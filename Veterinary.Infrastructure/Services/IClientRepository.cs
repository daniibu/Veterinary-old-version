
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infraestructure.Services
{
    public interface IClientRepository : IRepositoryGeneric<ClientFullDto>
    {
        //Ver muchos clientes:
        public Task<ClientFullDto> GetClientId (int id);
        
        




        //enumerable para mostrar la lista
        //una coleccion es un conjunto de objetos

        //debe tener los elementos que voy a ejecutar en la base de datos, 
        //CRUD=mostrar,insertar,modificar,eliminar
        //los metodos los vamos a crear como tarea: es un hilo que se ejecuta en el procesador
        //en paralelo con otros procesos que se van ejecutando, cuando creo esto es un proceso
        //nuevo en el procesador por cada usuario
    }
}

