using HR_DataAccessLayer.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
    public class Employees
    {
        public int id { get; set; }
        [MinLength(3,ErrorMessage ="Name must be greater than 3 chars")]
        public string Name { get; set; }
        public string Address { get; set; }
        [RegularExpression("^(+20)" ,ErrorMessage ="Phone Number isn't correct")]
        public string phoneNumber { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public DateOnly BirthDate { get; set; }
        [Required]

        [Unique]
        public int NationalID  { get; set; }
        public DateOnly ContractDate { get; set; }
        public decimal Salary { get; set; }
        public DateTime? Attendancetime { get; set; }
        public DateTime? Leavetime { get; set; }

        [ForeignKey("department")]
        public int departmentID { get; set; }
        public virtual Departments? department { get; set; }
        public virtual List<Attendances>? attendances { get; set; }
    }
}
