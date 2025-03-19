using HR_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Validations
{
    public class UniqueAttribute: ValidationAttribute
    {
        HR_SystemContext HR_SystemContext = new HR_SystemContext();
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
           int id = (int)value;
            Employees emp = (Employees)validationContext.ObjectInstance;
            if (HR_SystemContext.Employee.FirstOrDefault(c => c.NationalID == id ) == null)
            {

                return ValidationResult.Success;

            }

            return new ValidationResult($"{id} Already Exists");
        }
    }
}
