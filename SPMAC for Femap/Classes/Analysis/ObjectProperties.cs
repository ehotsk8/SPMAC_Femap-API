using System;
using femap;

namespace SPMAC_for_Femap
{
    class ObjectProperties
    {
        private model FemapModel;
        private int ID;

        public ObjectProperties(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void SetManualProperty(String Title, int Material)
        {
            Prop FemapProperty = FemapModel.feProp;
            FemapProperty.Active = 1;
            FemapProperty.title = Title;
            FemapProperty.matlID = Material;
            FemapProperty.type = zElementType.FET_P_SOLID;
            FemapProperty.Put(FemapProperty.CountSet() + 1);
            ID = FemapProperty.ID;
            FemapProperty.Reset();
        }

        public void SetPropertyFromList(int Id)
        {
            ID = Id;
        }

        public int GetPropID()
        {
            return ID;
        }
    }
}
