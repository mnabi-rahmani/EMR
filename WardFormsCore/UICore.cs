using System.Linq;
using System.Web.Mvc;
using WardFormsCore.DataModel;
using WardFormsCore.Repository;
using System.Web;



namespace WardFormsCore
{
    public  class UICore
    {

        public enum ElementTypes
        {
            String, Number, Date, Radio, Checkbox
        }

        public static string GenerateUIControl(int DSSEID, ElementTypes elementtype)
        {


            return "";
        }

            public static string GenerateUIList(int DSSEID, ElementTypes elementtype)
       {
            UnitOfWork UnitOfWork = new UnitOfWork(new WardFormsCoreDataModel());

            DataSetUIconfig DataSetUIconfigg = UnitOfWork.DataSetUIconfigs.Find(DataSetUIconfig => DataSetUIconfig.DSSEId == DSSEID).FirstOrDefault();

            string htmlgenerated;

            if (DataSetUIconfigg == null)
            {
                return "<li data-row='1' data-col='1' data-sizex='1' data-sizey='1' class='moveables' name=\'" + DSSEID + "\' >";


            }
            if (elementtype == ElementTypes.String)
            {

              //  var builder = new System.Web.Mvc.TagBuilder("li");

              //  // Create valid id
              ////  builder.GenerateId(id);

              //  // Add attributes
              //  builder.MergeAttribute("data-row", DataSetUIconfigg.data_row.ToString());
              //  builder.MergeAttribute("data-col", DataSetUIconfigg.data_col.ToString());
              //  builder.MergeAttribute("data-sizex", DataSetUIconfigg.data_sizex.ToString());
              //  builder.MergeAttribute("data-sizey", DataSetUIconfigg.data_sizey.ToString());

              //  builder.MergeAttribute("name", DataSetUIconfigg.DSSEId.ToString());
              //  builder.AddCssClass("moveables");

              //  //   builder.MergeAttribute("alt", alternateText);
              //  //   builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));



              //  // Render tag
              //  return builder.ToString(TagRenderMode.SelfClosing);

              //  //return htmlgenerated = "<li data-row = \'" + DataSetUIconfigg.data_row + "\'" +
              //  //                       "data-col = \'" + DataSetUIconfigg.data_col + "\'" +
              //  //                       "data-sizex = \'" + DataSetUIconfigg.data_sizex + "\'" +
              //  //                       " data-sizey = \'" + DataSetUIconfigg.data_sizey + "\'" +
              //  //                       " class='moveables' name=\'" + DataSetUIconfigg.DSSEId + "\'>";


               
                    
                   


            }
            else if (elementtype == ElementTypes.Date)
            {


            }
            else if (elementtype == ElementTypes.Number)
            {


            }
            else if (elementtype == ElementTypes.Checkbox)
            {


            }
            else if (elementtype == ElementTypes.Radio)
            {


            }
            
            return "";

       }

    }
}
