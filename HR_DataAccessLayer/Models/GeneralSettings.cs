using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
    public class GeneralSettings
    {
        public int id { get; set; }
        [Required]
        public decimal overTime { get; set; }
        [Required]
        public decimal Deduction { get; set; }
        [Required]
        public DayOfWeek WeeklyHoliday1 { get; set; }
        [Required]
        public DayOfWeek WeeklyHoliday2 { get; set; }

    }
}
