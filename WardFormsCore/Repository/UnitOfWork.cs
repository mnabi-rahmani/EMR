using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.Data;

namespace WardFormsCore.Repository
{
   public class UnitOfWork : IUnitOfWork
   {
       private readonly WardFormsCoreDataModel context;

       public UnitOfWork(WardFormsCoreDataModel _context)
       {
           context = _context;
            Elements= new ElementsRepository(context);
            DataSetUIconfigs = new DataSetUIconfigRepository(context);
       }
        public IElementsRepository Elements { get; private set; }
        public IDataSetUIconfigRepository DataSetUIconfigs { get; private set; }

        public int Complete()
       {

           return context.SaveChanges();

       }

       public void Dispose()
       {
            context.Dispose();

        }



   }
}
