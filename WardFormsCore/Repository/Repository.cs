using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.Data;

namespace WardFormsCore.Repository
{
   public class Repository : IRepository
    {

        WardFormsCoreDataModel db = new WardFormsCoreDataModel();


        public WardFormsCoreDataModel getmodel()
        {
            WardFormsCoreDataModel db = new WardFormsCoreDataModel();


            return db;


        }


        public string getdata(string charttype, string source)
        {


            return "test";
        }


    }
}
