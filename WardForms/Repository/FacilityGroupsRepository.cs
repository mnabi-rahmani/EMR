using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityGroupsRepository : Repository<FacilityGroup>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityGroupsRepository()
        {

        }



        public void UpdateFacilityGroups(FacilityGroup _facilityGroups)
        {
            Context.Entry(_facilityGroups).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}