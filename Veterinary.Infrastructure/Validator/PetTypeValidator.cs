
using FluentValidation;
using Veterinary.Core.Entities;

namespace Veterinary.Infrastructure.Validator
{
    public class PetTypeValidator : AbstractValidator<PetType>
    {
        public PetTypeValidator()
        {

        }
    }
}
