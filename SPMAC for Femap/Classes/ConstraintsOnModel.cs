using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap
{
    class ConstraintsOnModel
    {
        public void Set_Constraints(femap.model FemapModel)
        {
            femap.BCSet FemapConstraints = FemapModel.feBCSet;
            FemapConstraints.Active = 1;
            FemapConstraints.title = "Constraints";
            FemapConstraints.setID = 1;
            FemapConstraints.Put(1);

            femap.BCDefinition FemapConstraintsDedinition = FemapModel.feBCDefinition;
            FemapConstraintsDedinition.Active = 1;
            FemapConstraintsDedinition.title = "BCDef";
            FemapConstraintsDedinition.setID = 1;
            FemapConstraintsDedinition.dataType = zDataType.FT_BCO_GEOM;
            FemapConstraintsDedinition.OnType = zDataType.FT_SURFACE;
            FemapConstraintsDedinition.Put(1);

            femap.BCGeom FemapConstraintsGeom = FemapModel.feBCGeom;
            FemapConstraintsGeom.Active = 1;
            FemapConstraintsGeom.setID = 1;
            for (int i = 0; i < 6; i++)
                FemapConstraintsGeom.set_dof(i, true);
            FemapConstraintsGeom.type = zBCGeomType.FBG_DOF;
            FemapConstraintsGeom.geomTYPE = zDataType.FT_SURFACE;
            FemapConstraintsGeom.geomID = 5;
            FemapConstraintsGeom.BCDefinitionID = 1;
            FemapConstraintsGeom.Put(1);

            FemapConstraints.Reset();
            FemapConstraintsDedinition.Reset();
            FemapConstraintsGeom.Reset();
        }
    }
}
