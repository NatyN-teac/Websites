using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BHSM.Models
{
    public class DateTimeValid: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d/mmm/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime.ToString() == DateTime.Now.ToString("d/mmm/yyyy"));
        }
    }
}