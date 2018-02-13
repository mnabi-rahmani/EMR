using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityGeoLocsRepository : Repository<FacilityLocationGeoPiont>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityGeoLocsRepository()
        {

        }

        public List<FacilityLocationGeoPiont> GetAllLoc()
        {
            return Context.FacilityLocationGeoPionts.ToList();

     


        }

        public void UpdateLocs(FacilityLocationGeoPiont _facilitLocs)
        {
            Context.Entry(_facilitLocs).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}