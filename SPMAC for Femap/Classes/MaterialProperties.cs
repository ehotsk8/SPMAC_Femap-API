using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap
{
    class MaterialProperties
    {
        public void Set_Property(femap.model FemapModel)
        {
            femap.Matl FemapMaterial = FemapModel.feMatl;
            FemapMaterial.Active = 1;
            FemapMaterial.type = zMaterialType.FMT_ISOTROPIC;
            FemapMaterial.GetLibrary(0);
            FemapMaterial.Put(1);

            FemapMaterial.Reset();
        }
    }
}
