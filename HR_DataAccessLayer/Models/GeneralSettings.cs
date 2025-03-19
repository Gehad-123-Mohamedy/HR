using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
    public class GeneralSettings
    {
        public int id { get; set; }
        public decimal overTime { get; set; }
        public decimal Deduction { get; set; }
        public DayOfWeek WeeklyHoliday1 { get; set; }
        public DayOfWeek WeeklyHoliday2 { get; set; }

    }
}
