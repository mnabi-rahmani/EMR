using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityContactMechsRepository : Repository<FacilityContactMechanisim>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityContactMechsRepository()
        {

        }

    

        public void UpdateFacilityContactMech(FacilityContactMechanisim _facilityContactMechs)
        {
            Context.Entry(_facilityContactMechs).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}