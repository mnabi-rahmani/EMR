using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class ProvincesRepository : Repository<Province>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public ProvincesRepository()
        {

        }

        public List<Province> GetAllProvinces()
        {

           return  Context.Provinces.ToList();


        }

        public void UpdateProvince(Province _province)
        {
            Context.Entry(_province).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}