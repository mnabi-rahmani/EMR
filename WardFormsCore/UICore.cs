using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.DataModel;
using WardFormsCore.Repository;

namespace WardFormsCore
{
   public  class UICore
    {
       public static string GenerateUI(int DSSEID)
       {
           string htmlgenerated; 
            UnitOfWork UnitOfWork = new UnitOfWork(new WardFormsCoreDataModel());

            DataSetUIconfig DataSetUIconfigg=  UnitOfWork.DataSetUIconfigs.Find(DataSetUIconfig => DataSetUIconfig.DSSEId == DSSEID).FirstOrDefault();

           if (DataSetUIconfigg != null)
           {

            return   htmlgenerated = "<li data-row = \'" + DataSetUIconfigg.data_row + "\'" +
                               "data-col = \'" + DataSetUIconfigg.data_col + "\'" +
                               "data-sizex = \'" + DataSetUIconfigg.data_sizex + "\'" +
                               " data-sizey = \'" + DataSetUIconfigg.data_sizey +"\'" +
                               " class='moveables' name=\'" + DataSetUIconfigg.DSSEId + "\'>";


           }
           else
           {
               return
                   htmlgenerated ="<li data-row='1' data-col='1' data-sizex='1' data-sizey='1' class='moveables' name=\'" + DSSEID + "\' >";



           }


           
       }

    }
}
