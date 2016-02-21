using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap
{
    class ObjectProperties
    {
        public void Set_Property(femap.model FemapModel)
        {
            femap.Prop FemapProperty = FemapModel.feProp;
            FemapProperty.Active = 1;
            FemapProperty.setID = 1;
            FemapProperty.title = "Property";
            FemapProperty.matlID = 1;
            FemapProperty.type = zElementType.FET_P_SOLID;
            FemapProperty.Put(1);

            FemapProperty.Reset();
        }
    }
}
