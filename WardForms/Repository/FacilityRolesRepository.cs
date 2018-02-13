using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityRolesRepository : Repository<Province>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityRolesRepository()
        {

        }

       

        public void UpdateFacilityRoles(FacilityRole _facilityRoles)
        {
            Context.Entry(_facilityRoles).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}