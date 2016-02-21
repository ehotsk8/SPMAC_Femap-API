using System;
using System.Threading;
using femap;

namespace SPMAC_for_Femap
{
    class MeshingObject
    {
        private model FemapModel;
        private zReturnCode returnCode;

        public MeshingObject(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public zReturnCode SetMesh(int Property, double MeshSize)
        {
            Set set = FemapModel.feSet;
            set.Select(zDataType.FT_SOLID, true, "Select SOLID");
            int ID = 0;
            for (int i = 0; i < set.Count(); i++)
            {
                ID = set.Next();
                FemapModel.feFileRebuild(false, true);
                FemapModel.feMeshSizeSolid(ID, true, MeshSize, 1, 25, 6, 0, 0, true, 0, 0, false, false, false, false, false);
                FemapModel.feFileRebuild(false, true);
                returnCode = FemapModel.feMeshTetSolid2(zDataType.FT_SOLID, ID, Property,
                     false, true, 1.1, false, true, false, 0, false, true, 3);
                FemapModel.feFileRebuild(false, true); 
            }
            return returnCode;
        }
    }
}
