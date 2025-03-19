using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataAccessLayer.Models
{
    public class HR_SystemContext : DbContext
    {
        public HR_SystemContext():base()
        {
            
        }
        public HR_SystemContext(DbContextOptions<HR_SystemContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Attendances> Attendance { get; set; }
        public virtual DbSet<Departments> Department { get; set; }
        public virtual DbSet<Employees> Employee { get; set; }
        public virtual DbSet<OfficialVaccations> officialVaccations { get; set; }

    }
}
