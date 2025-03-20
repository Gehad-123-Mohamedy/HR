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
        [Required]
        [MinLength(3,ErrorMessage ="Name must be greater than 3 chars")]
        public string Name { get; set; }
        public string Address { get; set; }
        [RegularExpression("^(+20)" ,ErrorMessage ="Phone Number isn't correct")]
        public string phoneNumber { get; set; }
        [RegularExpression("^(Male|Female)$", ErrorMessage = "Gender must be Male or Female")]
        public string Gender { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        [Unique]
        public int NationalID  { get; set; }
        [Required]
        public DateOnly ContractDate { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public DateTime? Attendancetime { get; set; }
        [Required]
        public DateTime? Leavetime { get; set; }
        [ForeignKey("department")]
        public int departmentID { get; set; }
        public virtual Departments? department { get; set; }
        public virtual List<Attendances>? attendances { get; set; }
        public bool IsDeleted { get; set; }
    }
}
