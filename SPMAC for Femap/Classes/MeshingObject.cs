using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMAC_for_Femap
{
    class MeshingObject
    {
        public void Set_Mesh(femap.model FemapModel)
        {
            FemapModel.feMeshHexSolid(-1, 1, false, false, false, true, false, 0);
            // FemapModel.feMeshTetSolid(zDataType.FT_BCO_GEOM, -1, 1, false, false, 1, false, false, false, 0, 0);
        }
    }
}
