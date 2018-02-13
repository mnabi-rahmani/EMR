using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilitiesRepository : Repository<Facility>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilitiesRepository()
        {

        }

        public List<Facility> GetAllFacilities()
        {

            return Context.Facilities.ToList();


        }

        public void UpdateFacility(Facility _facilities)
        {
            Context.Entry(_facilities).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}