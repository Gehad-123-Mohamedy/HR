using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
   public class OfficialVaccations
   {
        public int id { get; set; }
        public string name { get; set; }
        public DateOnly date { get; set; }

   }
}
