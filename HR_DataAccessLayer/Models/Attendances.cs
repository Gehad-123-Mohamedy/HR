using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
    public class Attendances
    {
        public int id { get; set; }

        [ForeignKey("employee")]
        public int employeeID { get; set; }
        public virtual Employees? employee { get; set; }

        public DateTime? AttendenceTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        [Required]
        public DateOnly Day { get; set; }
        [Required]
        public bool IsAttendant { get; set; }
    }
}
