using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityContentsRepository : Repository<FacilityContent>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityContentsRepository()
        {

        }

        public List<FacilityContent> GetAllContents()
        {
            return Context.FacilityContents.ToList();

      


        }
        public void UpdateContent(FacilityContent _facilityContent)
        {
            Context.Entry(_facilityContent).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}