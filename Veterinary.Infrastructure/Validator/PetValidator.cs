using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary.Core.Entities;
using FluentValidation;

namespace Veterinary.Infrastructure.Validator
{
    public class PetValidator : AbstractValidator<Pet>
    {

        public PetValidator()
        {

        }
    }
}
