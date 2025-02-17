﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities
{
    public static class Utility
    {
        /// <summary>
        /// Nesneyi Validator kullanarak doğrulama yapar
        /// </summary>
        /// <param name="validator">IValidator'dan implemente edilmiş Validator</param>
        /// <param name="entity">Doğrulanacak Entity</param>
        /// <exception cref="ValidationException"></exception>
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
