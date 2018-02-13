using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityContactMechPurposesRepository : Repository<FacilityContactMechanisimPurpose>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityContactMechPurposesRepository()
        {

        }

        public List<FacilityContactMechanisimPurpose> GetAllPurposes()
        {
           
            return Context.FacilityContactMechanisimPurposes.ToList();




        }

        public void UpdateFacilityContactMechPurpose(FacilityContactMechanisimPurpose _facilityContactMechPurpose)
        {
            Context.Entry(_facilityContactMechPurpose).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}