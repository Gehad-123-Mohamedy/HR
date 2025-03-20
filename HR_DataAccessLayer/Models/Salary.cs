using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
    public class Salary
    {
        public int id { get; set; }
        [ForeignKey("employee")]
        public int employeeID { get; set; }
        public virtual Employees? employee { get; set; }
        public decimal NetSalary { get; set; }
        public decimal DeductionsPerHours { get; set; }
        public decimal AttendancePerHours { get; set; }
        public decimal TotalAttendance { get; set; }
        public decimal TotalDeductions { get; set; }
        [Required]
        [Range(1950, 2100, ErrorMessage = "Please enter valid Year")]
        public int Years { get; set; }

        [Required]
        [EnumDataType(typeof(MonthEnum))]
        public MonthEnum Month { get; set; }
    }
    public enum MonthEnum
    {
        [Display(Name = "January")]
        January = 1,

        [Display(Name = "February")]
        February = 2,

        [Display(Name = "March")]
        March = 3,

        [Display(Name = "April")]
        April = 4,

        [Display(Name = "May")]
        May = 5,

        [Display(Name = "June")]
        June = 6,

        [Display(Name = "July")]
        July = 7,

        [Display(Name = "August")]
        August = 8,

        [Display(Name = "September")]
        September = 9,

        [Display(Name = "October")]
        October = 10,

        [Display(Name = "November")]
        November = 11,

        [Display(Name = "December")]
        December = 12
    }

}
