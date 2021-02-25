using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ValidationException = FluentValidation.ValidationException;

namespace Core.CrossCottingConcerns.Validation
{
  public static  class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<Object>(entity);

            var result = validator.Validate(context);
            if (!result.IsValid) //sonuc gecerli değil ise 
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
