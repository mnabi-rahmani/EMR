using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.DataModel;

namespace WardFormsCore.Repository
{

    public interface IRepository<Tentity> where Tentity : class
    {
        //void save();

        Tentity Get(int id);

        IEnumerable<Tentity> GetAll();
        IEnumerable<Tentity> Find(Expression<Func<Tentity, bool>> predicate);

        void Add(Tentity entity);
        void AddRange(IEnumerable<Tentity> entities);

        void Remove(Tentity entity);
        void RemoveRange(IEnumerable<Tentity> entities);

       // WardFormsCoreDataModel getmodel();

      //  void save();

     //   string getdata(string charttype, string source);



    }
  

}
