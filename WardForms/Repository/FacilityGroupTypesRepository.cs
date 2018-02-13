using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityGroupTypesRepository : Repository<FacilityGroupType>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityGroupTypesRepository()
        {

        }

    

        public void UpdateFacilityGroupTypes(FacilityGroupType _FacilityGroupType)
        {
            Context.Entry(_FacilityGroupType).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}