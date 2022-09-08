using Veterinary.Core.DTOs;
using Veterinary.Infraestructure.Services;
using Microsoft.EntityFrameworkCore;
using Veterinary.Infrastructure.Data;

namespace Veterinary.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        //inyectar la independecia a la interfaz y el repositorio
        private readonly VeterinaryContext context;

        public ClientRepository(VeterinaryContext context)
        {
            this.context = context; //esto es el constructor
        }

        public  async Task DeleteClientById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ClientFullDto> GetClientId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClientFullDto>> GetAll()
        {
            List<ClientFullDto> clientFullDtos = new();
            if (context.Clients == null)
            {
                return clientFullDtos;
            }
            else 
            {
                var clients = await context.Clients.ToListAsync();
                if (clients != null) 
                {
                    
                    foreach (var client in clients) 
                    {
                        clientFullDtos.Add(new ClientFullDto
                        {
                            clientId = client.clientId,
                            clientName= client.clientName,
                        });
                    }

                    return clientFullDtos;
                }
                else 
                { 
                    return clientFullDtos; 
                }
                
            }
        }

        public async Task InsertClientById(ClientFullDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateClientById(ClientFullDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClientFullDto>> GetClientId()
        {
            throw new NotImplementedException();
        }
    }
}
