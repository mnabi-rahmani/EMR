using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityTypesRepository : Repository<FacilityType>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityTypesRepository()
        {

        }

        public List<FacilityType> GetAllTypes()
        {

            return Context.FacilityTypes.ToList();


        }

        public void UpdateFacility(FacilityType _facilitTypes)
        {
            Context.Entry(_facilitTypes).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}