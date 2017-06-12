using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.Data;

namespace WardFormsCore.Repository
{
    public class DataSetUIconfigRepository : Repository<DataSetUIconfig> , IDataSetUIconfigRepository
    {
        public DataSetUIconfigRepository(WardFormsCoreDataModel context ) :base(context)
        {

        }

        public WardFormsCoreDataModel WardformsContext
        {
            get{ return Context as WardFormsCoreDataModel; }
        }

        public bool DatasetUIConfigExists(int DatasetSectionElementID)
        {
            IEnumerable<DataSetUIconfig> dsuilist;
            dsuilist = this.Find(DataSetUIconfig => DataSetUIconfig.DSSEId == DatasetSectionElementID);

            //List<DataSetUIconfig> dsuilist = (from a in dbb.datasetUIconfig
            //     where a.DSSEId == id
            //     select a).ToList();

            if (dsuilist.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void AddorUpdateExisting(string data_row, string data_col, string data_sizex, string data_sizey,
            string name)
        {

            int DatasetSectionElementID = Convert.ToInt32(name);
            DataSetUIconfig dsui = new DataSetUIconfig();

            dsui = this.Find(DataSetUIconfig => DataSetUIconfig.DSSEId == DatasetSectionElementID).FirstOrDefault();

            if (dsui != null)
            {
            dsui.data_row = Convert.ToInt32(data_row);
            dsui.data_col = Convert.ToInt32(data_col);
            dsui.data_sizex = Convert.ToInt32(data_sizex);
            dsui.data_sizey = Convert.ToInt32(data_sizey);
            dsui.DSSEId = Convert.ToInt32(name);
            dsui.DSUIID = dsui.DSUIID;
                WardformsContext.datasetUIconfig.AddOrUpdate(dsui);

            }
            else
            {
                DataSetUIconfig dsui2 = new DataSetUIconfig();
                dsui2.data_row = Convert.ToInt32(data_row);
                dsui2.data_col = Convert.ToInt32(data_col);
                dsui2.data_sizex = Convert.ToInt32(data_sizex);
                dsui2.data_sizey = Convert.ToInt32(data_sizey);
                dsui2.DSSEId = Convert.ToInt32(name);
                // dsui.DSUIID = dsui.DSUIID;
                WardformsContext.datasetUIconfig.AddOrUpdate(dsui2);
            }
       


        }

        public IEnumerable<AllElement> getallelements()
        {
            return WardformsContext.AllElements.ToList();


        }



    }
}
