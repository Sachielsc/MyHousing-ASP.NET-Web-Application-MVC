using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MyHousing.Validation
{
    public class ValidDatepickerAttribute : ValidationAttribute
    {
        //public override bool IsValid(object value)
        //{
        //    DateTime dtout;

        //    if (DateTime.TryParseExact(value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtout))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dtout;

            if (DateTime.TryParseExact(value.ToString(), "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtout))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid date format");
        }

    }
}