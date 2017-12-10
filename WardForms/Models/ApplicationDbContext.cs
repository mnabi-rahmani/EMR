using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WardForms.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public DbSet<Person> Persons { get; set;  }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WardForms.Models.District> Districts { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.Province> Provinces { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.Facility> Facilities { get; set; }
    }
}