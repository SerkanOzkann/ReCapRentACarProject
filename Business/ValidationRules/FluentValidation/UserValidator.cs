using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserFirstName).MinimumLength(3);
            RuleFor(u => u.UserLastName).MinimumLength(3);
            RuleFor(u => u.UserEmail).EmailAddress();
            RuleFor(u => u.Password).NotEmpty();

            RuleFor(u => u.Password).MinimumLength(8)
                .WithMessage("Şifreniz en az 8 karekter içermelidir.");

          



        }
    }
}
