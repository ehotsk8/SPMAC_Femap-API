using System;
using System.Collections.Generic;
using femap;

namespace SPMAC_for_Femap
{
    class MaterialProperties
    {
        private model FemapModel;

        public MaterialProperties(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void SetAutoMaterial(int id)
        {
            Matl FemapMaterial = FemapModel.feMatl;
            FemapMaterial.Active = 1;
            FemapMaterial.type = zMaterialType.FMT_ISOTROPIC;
            FemapMaterial.GetLibrary(id);
            FemapMaterial.Put(1);
            FemapMaterial.Reset();
            FemapModel.feView.Regenerate();
        }

        public List<Matl> GetMatLibrary()
        {
            List<Matl> materials = new List<Matl>();
            Matl FemapMaterial = FemapModel.feMatl;
            int i = 0;
            while (FemapMaterial.GetLibrary(i++) != zReturnCode.FE_FAIL)
            {
                FemapMaterial = FemapModel.feMatl;
                materials.Add(FemapMaterial);
            }
            return materials;
        }

        public void SetManualMaterial(String Title, Double E, Double G, Double Nu)
        {
            Matl FemapMaterial = FemapModel.feMatl;
            FemapMaterial.Active = 1;
            FemapMaterial.type = zMaterialType.FMT_ISOTROPIC;
            FemapMaterial.title = Title;
            FemapMaterial.Ex = E;
            FemapMaterial.Gx = G;
            FemapMaterial.Nuxy = Nu;
            FemapMaterial.Put(FemapMaterial.CountSet() + 1);
            FemapMaterial.Reset();
            FemapModel.feView.Regenerate();
        }
    }
}
