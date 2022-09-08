using FluentValidation;
using Veterinary.Core.Entities;

namespace Veterinary.Infrastructure.Validator
{
    public class ProcedureValidator : AbstractValidator<Procedure>
    {
        public ProcedureValidator()
        {

        }
    }
}
