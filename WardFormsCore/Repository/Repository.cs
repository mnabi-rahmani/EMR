using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.DataModel;

namespace WardFormsCore.Repository
{
   public class Repository<Tentity> : IRepository<Tentity> where Tentity:class
    {

        //WardFormsCoreDataModel db = new WardFormsCoreDataModel();
       protected DbContext Context;

       //public void save()
       //{

       //    Context.SaveChanges();
       //}

       public Repository(DbContext dbContext)
       {
           Context = dbContext;


       }

     



        public Tentity Get(int id)
        {
            return Context.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> GetAll()
        {

            return Context.Set<Tentity>().ToList();

        }

        public IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate)
        {
            return Context.Set<Tentity>().Where(predicate);
        }

        public void Add(Tentity entity)
        {
            Context.Set<Tentity>().Add(entity);

        }

        public void AddRange(IEnumerable<Tentity> entities)
        {
            Context.Set<Tentity>().AddRange(entities);
        }

        public void Remove(Tentity entity)
        {
            Context.Set<Tentity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<Tentity> entities)
        {
            Context.Set<Tentity>().RemoveRange(entities);
        }


    }
}
