using System;
using System.Collections.Generic;
using femap;

namespace SPMAC_for_Femap.Classes
{
    class ConstraintsOnModel
    {
        private model FemapModel;
        private List<double> surfaceIds = new List<double>();

        public ConstraintsOnModel(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void SetConstraints(String Title, bool TX, bool TY, bool TZ, bool RX, bool RY, bool RZ)
        {
            if (FemapModel.feSolid.CountSet() > 0)
            {
                BCSet femapConstraints = FemapModel.feBCSet;
                femapConstraints.Active = 1;
                femapConstraints.title = Title;
                femapConstraints.Put(1);

                BCDefinition femapConstraintsDedinition = FemapModel.feBCDefinition;
                femapConstraintsDedinition.Active = 1;
                femapConstraintsDedinition.dataType = zDataType.FT_BCO_GEOM;
                femapConstraintsDedinition.OnType = zDataType.FT_SURFACE;
                femapConstraintsDedinition.Put(femapConstraintsDedinition.CountSet() + 1);

                BCGeom femapConstraintsGeom = FemapModel.feBCGeom;
                femapConstraintsGeom.Active = 1;
                femapConstraintsGeom.setID = 1;
                femapConstraintsGeom.set_dof(0, TX);
                femapConstraintsGeom.set_dof(1, TY);
                femapConstraintsGeom.set_dof(2, TZ);
                femapConstraintsGeom.set_dof(3, RX);
                femapConstraintsGeom.set_dof(4, RY);
                femapConstraintsGeom.set_dof(5, RZ);
                femapConstraintsGeom.type = zBCGeomType.FBG_DOF;
                femapConstraintsGeom.geomTYPE = zDataType.FT_SURFACE;
                Set set = FemapModel.feSet;
                set.Select(zDataType.FT_SURFACE, true, "Select SURFACE");
                for (int i = 0; i < set.Count(); i++)
                {
                    femapConstraintsGeom.geomID = set.Next();
                    surfaceIds.Add(set.CurrentID);
                    femapConstraintsGeom.Put(femapConstraintsGeom.CountSet() + 1);
                }

                femapConstraints.Reset();
                femapConstraintsDedinition.Reset();
                femapConstraintsGeom.Reset();
            }
            FemapModel.feFileRebuild(false, false);
        }

        public List<double> SurfaseList()
        {
            return surfaceIds;
        }
    }
}
