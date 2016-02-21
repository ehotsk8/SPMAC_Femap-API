using System;
using System.Collections.Generic;
using femap;

namespace SPMAC_for_Femap
{
    class LoadOnModel
    {
        private model FemapModel;
        private List<double> surfaceIds = new List<double>();

        public LoadOnModel(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void Set_Load(String TitleLoadSet, Double Value, zLoadType LoadType, Double X, Double Y, Double Z)
        {
            if (FemapModel.feSolid.CountSet() > 0)
            {
                LoadSet FemapLoadSet = FemapModel.feLoadSet;
                FemapLoadSet.Active = 1;
                FemapLoadSet.setID = 1;
                FemapLoadSet.title = TitleLoadSet;
                FemapLoadSet.Put(1);

                LoadDefinition FemapLoadDefinition = FemapModel.feLoadDefinition;
                FemapLoadDefinition.Active = 1;
                FemapLoadDefinition.dataType = zDataType.FT_GEOM_LOAD;
                FemapLoadDefinition.loadType = LoadType;
                FemapLoadDefinition.Put(FemapLoadDefinition.CountSet() + 1);

                LoadGeom FemapLoadGeometry = FemapModel.feLoadGeom;
                FemapLoadGeometry.Active = 1;
                FemapLoadGeometry.geomTYPE = zDataType.FT_SURFACE;
                FemapLoadGeometry.type = LoadType;
                FemapLoadGeometry.Pressure = Value;
                FemapLoadGeometry.x = X;
                FemapLoadGeometry.XOn = true;
                FemapLoadGeometry.y = Y;
                FemapLoadGeometry.YOn = true;
                FemapLoadGeometry.z = Z;
                FemapLoadGeometry.ZOn = true;
                FemapLoadGeometry.FaceNumber = 1;
                Set set = FemapModel.feSet;
                set.Select(zDataType.FT_SURFACE, true, "Select SURFACE");
                for (int i = 0; i < set.Count(); i++)
                {
                    FemapLoadGeometry.geomID = set.Next();
                    surfaceIds.Add(set.CurrentID);
                    FemapLoadGeometry.Put(FemapLoadGeometry.CountSet() + 1);
                }
                FemapLoadSet.Reset();
                FemapLoadDefinition.Reset();
                FemapLoadGeometry.Reset();
            }
            FemapModel.feFileRebuild(false, false);
        }

        public List<double> SurfaseList()
        {
            return surfaceIds;
        }
    }
}
