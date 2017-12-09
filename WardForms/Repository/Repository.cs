using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WardForms.Models;

namespace WardForms.Repository
{
   public class Repository<Tentity> : IRepository<Tentity> where Tentity:class
    {

        ApplicationDbContext ApplicationDbContext = new ApplicationDbContext();
      

        public void save()
        {

            ApplicationDbContext.SaveChanges();
        }

        public Repository(ApplicationDbContext _ApplicationDbContext)
       {
            ApplicationDbContext = _ApplicationDbContext;


       }

     



        public Tentity Get(int id)
        {
            return ApplicationDbContext.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> GetAll()
        {

            return ApplicationDbContext.Set<Tentity>().ToList();

        }

        public IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate)
        {
            return ApplicationDbContext.Set<Tentity>().Where(predicate);
        }

        public void Add(Tentity entity)
        {
            ApplicationDbContext.Set<Tentity>().Add(entity);

        }

        public void AddRange(IEnumerable<Tentity> entities)
        {
            ApplicationDbContext.Set<Tentity>().AddRange(entities);
        }

        public void Remove(Tentity entity)
        {
            ApplicationDbContext.Set<Tentity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<Tentity> entities)
        {
            ApplicationDbContext.Set<Tentity>().RemoveRange(entities);
        }


    }
}
