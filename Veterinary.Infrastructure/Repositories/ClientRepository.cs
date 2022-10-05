using Veterinary.Core.DTOs;
using Veterinary.Infraestructure.Services;
using Microsoft.EntityFrameworkCore;
using Veterinary.Infrastructure.Data;

namespace Veterinary.Infrastructure.Repositories
{
    //Las tareas deben de ser asincronas para que el programa siga ejecutandose en otras tareas
    public class ClientRepository : IClientRepository
    {
        //Inyecto el contexto (con una propiedad de solo lectura)
        private readonly VeterinaryContext context;
        //Constructor:
        //Este objeto se llama igual que el anterior, para distinguir uno del otro se usa el this.
        public ClientRepository(VeterinaryContext context)
        {
            //El this habla de la clase. Entonces el de la izquierda es el de fuera y el otro es el de dentro de esta clase.
            this.context = context;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClientFullDto>> GetAll()
        {
            //Se declara la lista del dto al principio para que sea visible para todo el bloque.
            //Como aun no esta devolviendo errores se devuelve una lista vacía.
            List<ClientFullDto> clientDto = new();
            //Primero chequeo la existencia del cliente
            if (context.Clients == null)
            {
                //Si no existe retorna un error
                return clientDto;
            }
            //Sino
            else
            {
                //Lo que viene de la base de datos lo asigno a este objeto. El if es por si no se trae nada de la base de datos.
                //Crea un objeto que en su interior recibirá una lista de forma asyncrona de todos los clientes de la base de datos
                var clients = await context.Clients.ToListAsync();
                //Si el objeto no es nulo
                if (clients != null)
                {
                    //Buscara dentro de cada cliente, cliente por cliente. Si hay clientes usará el foreach para mapear los
                    //atributos de cada uno de ellos. De las entidades, a los Dtos.
                    foreach (var client in clients)
                    {
                        //Al cliente le devuelvo el Dto porque así decido que mostrarle y que no, para evitar traer información inecesaria.
                        //Los dto no usan propiedades de navegación, sino la entidad y solo si se usa entity framework, por lo que no deben ir en los dto.
                        clientDto.Add(new ClientFullDto
                        //Por cada elemento de la lista lo agregará de la entidad al DTO.
                        {
                            clientId = client.clientId,
                            clientName = client.clientName,
                            clientSurname = client.clientSurname,
                            clientAdress = client.clientAdress,
                            clientPhoneNum = client.clientPhoneNum,
                            clientIdn = client.clientIdn,
                            dateUpdate = client.dateUpdate,
                            dateUpload = client.dateUpload,
                            user = client.user
                        });
                    }
                    return clientDto;
                }
                else
                {
                    return clientDto;
                }
            }
        }
        public Task<ClientFullDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ClientFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(ClientFullDto entity)
        {
            throw new NotImplementedException();
        }


        ////inyecto el contexto(con una propiedad de solo lectura)
        //private readonly VeterinaryContext context;

        //public ClientRepository(VeterinaryContext context)
        //{
        //    this.context = context; //esto es el constructor
        //    //el objeto se llama igual que el anterior, para distinguir uno del otro se usa el this
        //}

        //public  async Task Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task DeleteClientById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<ClientFullDto>> GetAll()
        //{
        //    //Se declara la lista del dto al principio para que sea visible para todo el bloque.
        //    //Como aun no esta devolviendo errores se devuelve una lista vacía.
        //    List<ClientFullDto> clientDtos = new();
        //    //primero veo si el hay existencia del cliente
        //    if (context.Clients == null)
        //    {
        //        //si no existe el cliente retorna en error
        //        return clientDtos;
        //    }
        //    //sino
        //    else 
        //    {
        //        //Lo que viene de la base de datos lo asigno a este objeto. El if es por si no se trae nada de la base de datos.
        //        //Crea un objeto que en su interior recibirá una lista de forma asyncrona de todos los clientes de la base de datos
        //        var clients = await context.Clients.ToListAsync();
        //        //si el objeto no es nulo
        //        if (clients != null) 
        //        {
        //            //Buscara dentro de cada cliente, cliente por cliente. Si hay clientes usará el foreach para mapear los
        //            //atributos de cada uno de ellos. De las entidades, a los Dtos.
        //            foreach (var client in clients) 
        //            {
        //                //Al cliente le devuelvo el Dto porque así decido que mostrarle y que no, para evitar traer información inecesaria.
        //                //Los dto no usan propiedades de navegación, sino la entidad y solo si se usa entity framework, por lo que no deben ir en los dto.
        //                clientDtos.Add(new ClientFullDto
        //                //Por cada elemento de la lista lo agregará de la entidad al DTO.
        //                {
        //                    clientId = client.clientId,
        //                    clientName= client.clientName,
        //                    clientSurname= client.clientSurname,
        //                    clientAdress= client.clientAdress,
        //                    clientPhoneNum=client.clientPhoneNum,
        //                    clientIdn= client.clientIdn,
        //                    dateUpdate= client.dateUpdate,
        //                    dateUpload= client.dateUpload,
        //                    user=client.user
        //                });
        //            }

        //            return clientDtos;
        //        }
        //        else 
        //        { 
        //            return clientDtos; 
        //        }

        //    }
        //}

        //public Task<ClientFullDto> GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<ClientFullDto>> GetClientId()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task InsertClientById(ClientFullDto entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateClientById(ClientFullDto entity)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
