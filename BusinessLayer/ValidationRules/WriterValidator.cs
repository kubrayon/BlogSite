using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş bırakamazsınız.");
           
        }
    }
}
