using femap;
using SPMAC_for_Femap.Classes.DB;

namespace SPMAC_for_Femap.Classes.Analysis
{
    class OutputResults
    {
        private readonly model FemapModel;

        private double sMax, sMin;
        private int sMinID, sMaxID;

        private double tMax, tMin;
        private int tMinID, tMaxID;

        public OutputResults(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void AddResultsToDb()
        {
            OutputSet outSet = FemapModel.feOutputSet;
            Output output = FemapModel.feOutput;
            Output output2 = FemapModel.feOutput;
            var db = new DBController();

            for (int i = 0; i < outSet.CountSet(); i++)
            {
                outSet.Next();
                Set select = FemapModel.feSet;
                select.Select(zDataType.FT_NODE, true, "Выберите узлы");

                output.Get(60031);
                output.FindMaxMin(select.ID, true, out sMinID, out sMin, out sMaxID, out sMax);
                output2.Get(1);
                output2.FindMaxMin(select.ID, true, out tMinID, out tMin, out tMaxID, out tMax);

                db.AddResultMaxMin(sMinID, sMin, sMaxID, sMax, tMinID, tMin, tMaxID, tMax);

                for (int index = 0; index < select.Count(); index++)
                {
                    select.Next();
                    db.AddResult("Результат", select.CurrentID, output2.Value[select.CurrentID], output.Value[select.CurrentID], index);
                }
            }
            db.SaveResult();
        }
    }
}
