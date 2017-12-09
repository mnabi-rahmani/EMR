using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;

namespace WardForms.Repository
{
    public class PersonRepository : Repository<Employee>
    {
        ApplicationDbContext ApplicationDbContext = new ApplicationDbContext();

        public PersonRepository( ) : base()
        {
            
        }


       


    }
}