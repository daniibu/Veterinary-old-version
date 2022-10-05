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
    public class PetTypeRepository : IPetTypeRepository
    {
        private readonly VeterinaryContext context;
        public PetTypeRepository(VeterinaryContext context)
        {
            //El this habla de la clase. Entonces el de la izquierda es el de fuera y el otro es el de dentro de esta clase.
            this.context = context;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeletePetTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PetTypeFullDto>> GetAll()
        {
            List<PetTypeFullDto> typeFullDtos = new();
            if (context.PetTypes == null)
            {
                //Si no existe retorna un error
                return typeFullDtos;
            }
            else
            {
                var petTypes = await context.PetTypes.ToListAsync();
                if (petTypes != null)
                {
                    foreach (var petType in petTypes)
                    {

                        typeFullDtos.Add(new PetTypeFullDto
                        //Por cada elemento de la lista lo agregará de la entidad al DTO.
                        {
                            typeId =petType.TypeId,
                            //agregar los demás que faltan
                        });
                    }
                    return typeFullDtos;
                }
                else
                {
                    return typeFullDtos;
                }

            }
        }

        public Task<IEnumerable<PetTypeFullDto>> GetAllPetType()
        {
            throw new NotImplementedException();
        }

        public Task<PetTypeFullDto> GetPetType(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(PetTypeFullDto entity)
        {
            throw new NotImplementedException();
        }

        public Task SavePetTypeById(PetTypeFullDto pet)
        {
            throw new NotImplementedException();
        }

        public Task Update(PetTypeFullDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
