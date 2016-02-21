using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap
{
    class AnalysisProperty
    {
        public void Set_Property(femap.model FemapModel)
        {
            femap.AnalysisMgr FemapAnalysis = FemapModel.feAnalysisSet;
            FemapAnalysis.Active = 1;
            FemapAnalysis.InitAnalysisMgr(zAnalysisMgrProgram.FAM_NX_NASTRAN, zAnalysisType.FAT_STATIC, true);
            FemapAnalysis.MarModProcessors = false;
            FemapAnalysis.Put(1);

            FemapAnalysis.Reset();
            FemapAnalysis.Analyze(1);
        }
    }
}
