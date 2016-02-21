using femap;

namespace SPMAC_for_Femap
{
    class AnalysisProperty
    {
        private model FemapModel;

        public AnalysisProperty(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void SetProperty()
        {
            AnalysisMgr FemapAnalysis = FemapModel.feAnalysisSet;
            FemapAnalysis.Active = 1;
            FemapAnalysis.InitAnalysisMgr(zAnalysisMgrProgram.FAM_NX_NASTRAN, zAnalysisType.FAT_STATIC, true);
            FemapAnalysis.MarModProcessors = false;
            FemapAnalysis.Put(1);
            FemapAnalysis.Reset();
            FemapAnalysis.Analyze(1);
        }
    }
}
