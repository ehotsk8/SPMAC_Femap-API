using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap
{
    class LoadOnModel
    {
        public void Set_Load(femap.model FemapModel)
        {
            femap.LoadSet FemapLoadSet = FemapModel.feLoadSet;
            FemapLoadSet.Active = 1;
            FemapLoadSet.setID = 1;
            FemapLoadSet.title = "Dummy LSet";
            FemapLoadSet.Put(1);

            femap.LoadDefinition FemapLoadDefinition = FemapModel.feLoadDefinition;
            FemapLoadDefinition.Active = 1;
            FemapLoadDefinition.setID = 1;
            FemapLoadDefinition.dataType = zDataType.FT_GEOM_LOAD;
            FemapLoadDefinition.loadType = zLoadType.FLT_SEPRESSURE;
            FemapLoadDefinition.Put(1);

            femap.LoadGeom FemapLoadGeometry = FemapModel.feLoadGeom;
            FemapLoadGeometry.Active = 1;
            FemapLoadGeometry.setID = 1;
            FemapLoadGeometry.geomTYPE = zDataType.FT_SURFACE;
            FemapLoadGeometry.type = zLoadType.FLT_SEPRESSURE;
            FemapLoadGeometry.geomID = 4;
            FemapLoadGeometry.Pressure = 100;
            FemapLoadGeometry.FaceNumber = 1;
            FemapLoadGeometry.LoadDefinitionID = 1;
            FemapLoadGeometry.Put(1);

            FemapLoadSet.Reset();
            FemapLoadDefinition.Reset();
            FemapLoadGeometry.Reset();
        }
    }
}
