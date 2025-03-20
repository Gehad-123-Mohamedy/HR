using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
   public class OfficialVaccations
   {
        public int id { get; set; }
        [Required]
        public required string name { get; set; }
        [Required]
        public DateOnly date { get; set; }

   }
}
