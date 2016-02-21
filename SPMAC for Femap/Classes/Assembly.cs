using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap
{
    class Assembly
    {
        public Assembly(femap.model FemapModel)
        {
            FemapModel.feFileNew();
            FemapModel.feFileReadStep("C:/FemapModels/Piston.stp");
            FemapModel.feFileReadStep("C:/FemapModels/Rod.stp");
            FemapModel.feFileReadStep("C:/FemapModels/Finger.stp");
            FemapModel.feFileReadStep("C:/FemapModels/CoverRod.stp");
            FemapModel.feFileReadStep("C:/FemapModels/Crankshaft.stp");         
            FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -1, zColor.FCL_GRAY130, 0, 1, 1);
            FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -2, zColor.FCL_GOLDENROD, 0, 1, 1);
            FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -3, zColor.FCL_GRAY220, 0, 1, 1);
            FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -4, zColor.FCL_GOLDENROD, 0, 1, 1);
            FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -5, zColor.FCL_DARKSEAGREEN, 0, 1, 1);

            Point[] points = new Point[100];
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[1].x = 0; points[1].y = 0; points[1].z = 0;
            points[2].x = 0; points[2].y = -51; points[3].z = 0;
            object vecDIRX, vecDIRY, vecDIRZ;
            FemapModel.feVectorAxis(-0, 0, true, out vecDIRX);
            FemapModel.feVectorAxis(-0, 2, true, out vecDIRZ);
            FemapModel.feVectorAxis(-0, 1, true, out vecDIRY);
            FemapModel.feAlignTo(zDataType.FT_SOLID, -1, points[2].xyz, vecDIRX, points[1].xyz, vecDIRZ);
            FemapModel.feAlignTo(zDataType.FT_SOLID, -1, points[0].xyz, vecDIRY, points[0].xyz, vecDIRX);
            FemapModel.Pref_WorkplaneNotVisible = true;
            FemapModel.feViewRegenerate(0);
            FemapModel.feFileSaveAs(false, "C:/FemapModels/Assembly.modfem");
        }
    }
}
