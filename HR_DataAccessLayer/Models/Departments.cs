using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
   public class Departments
   {
        public int id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name must be greater than 3 chars")]
        public string Name { get; set; }
        public string? description { get; set; }
        public virtual List<Employees>? employees { get; set; }
        public bool IsDeleted { get; set; }

    }
}
