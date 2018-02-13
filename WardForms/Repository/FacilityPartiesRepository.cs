using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityPartiesRepository : Repository<FacilityParty>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityPartiesRepository()
        {

        }

     

        public void UpdateFacilityParty(FacilityParty _facilityParty)
        {
            Context.Entry(_facilityParty).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}