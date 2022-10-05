using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Data;
using Veterinary.Infrastructure.Services;

namespace Veterinary.Infrastructure.Repositories
{
    public class VetRepository : IVetRepository
    {
        //Inyecto el contexto (con una propiedad de solo lectura)
        private readonly VeterinaryContext context;
        //Constructor:
        //Este objeto se llama igual que el anterior, para distinguir uno del otro se usa el this.
        public VetRepository(VeterinaryContext context)
        {
            //El this habla de la clase. Entonces el de la izquierda es el de fuera y el otro es el de dentro de esta clase.
            this.context = context;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VetFullDto>> GetAll()
        {
            //Se declara la lista del dto al principio para que sea visible para todo el bloque.
            //Como aun no esta devolviendo errores se devuelve una lista vacía.
            List<VetFullDto> vetFullDtos = new();
            //Primero chequeo la existencia del cliente
            if (context.Vets == null)
            {
                //Si no existe retorna un error
                return vetFullDtos;
            }
            //Sino
            else
            {
                //Lo que viene de la base de datos lo asigno a este objeto. El if es por si no se trae nada de la base de datos.
                //Crea un objeto que en su interior recibirá una lista de forma asyncrona de todos los clientes de la base de datos
                var vets = await context.Vets.ToListAsync();
                //Si el objeto no es nulo
                if (vets != null)
                {
                    //Buscara dentro de cada cliente, cliente por cliente. Si hay clientes usará el foreach para mapear los
                    //atributos de cada uno de ellos. De las entidades, a los Dtos.
                    foreach (var vet in vets)
                    {
                        //Al cliente le devuelvo el Dto porque así decido que mostrarle y que no, para evitar traer información inecesaria.
                        //Los dto no usan propiedades de navegación, sino la entidad y solo si se usa entity framework, por lo que no deben ir en los dto.
                        vetFullDtos.Add(new VetFullDto
                        //Por cada elemento de la lista lo agregará de la entidad al DTO.
                        {
                            vetId= vet.vetId,
                            //completar
                        });
                    }
                    return vetFullDtos;
                }
                else
                {
                    return vetFullDtos;
                }
            }
        }

        public Task Insert(VetFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(VetFullDto entity)
        {
            throw new NotImplementedException();
        }
    }    
}
