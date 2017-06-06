using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.Data;

namespace WardFormsCore.Repository
{
 public   interface IRepository
    {
        WardFormsCoreDataModel getmodel();

        
        string getdata(string charttype, string source);

    }
}
