using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.DataModel;

namespace WardFormsCore.Repository
{
    public class ElementsRepository : Repository<ElementValue> , IElementsRepository
    {
        public ElementsRepository(WardFormsCoreDataModel context ) :base(context)
        {

        }

        public WardFormsCoreDataModel WardformsContext
        {
            get{ return Context as WardFormsCoreDataModel; }
        }

         

    }
}
