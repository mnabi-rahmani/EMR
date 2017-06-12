using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardFormsCore.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IElementsRepository Elements { get; }
        IDataSetUIconfigRepository DataSetUIconfigs { get;  }
        int Complete();

    }
}
