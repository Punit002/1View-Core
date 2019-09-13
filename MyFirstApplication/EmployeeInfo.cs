using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace MyFirstApplication
{
    [Table("EmployeeInfo", Schema = "dbo")]
    public class EmployeeInfo : IValidatableObject
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var addressModel = validationContext.ObjectInstance as EmployeeInfo;
            var t = addressModel.GetType().GetProperties();
            foreach (PropertyInfo prop in addressModel.GetType().GetProperties())
            {
                var type = prop.PropertyType;
                if (type == typeof(int))
                {
                    

                } else if(type == typeof(string))
                {

                } else if (type == typeof(Guid))
                {

                }
            }
                throw new System.NotImplementedException();
        }
    }
}