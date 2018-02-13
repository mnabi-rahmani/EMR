using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityGroupRolesRepository : Repository<FacilityGroupRole>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityGroupRolesRepository()
        {

        }

       

        public void UpdateGroupRole(FacilityGroupRole _facilityGroupRole)
        {
            Context.Entry(_facilityGroupRole).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}