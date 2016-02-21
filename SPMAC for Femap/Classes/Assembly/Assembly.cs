using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using femap;
using SPMAC_for_Femap.Classes;

namespace SPMAC_for_Femap
{
    public class Assembly : ICancelModelling
    {
        private readonly model FemapModel;

        public Assembly(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public async Task CreateAssembly_Async(CancellationToken cts, string Path, bool rod,
            bool coverRod, bool piston, bool finger, bool crankshaft, bool cylinder)
        {
            SerializeXML serialize = new SerializeXML(Path + "/Sizes.XML");
            List<SIZE> list = serialize.DeSerializer();
            if (list.Count > 0)
            {
                cts.ThrowIfCancellationRequested();
                if (!cts.IsCancellationRequested)
                {
                    Status.CurrState = Status.CurrentState.ASSEMBLY;
                    FemapModel.feFileNew();
                    new SyncGUI(FemapModel).View();
                    Status.ProgressValue = 10;
                }
                if (!cts.IsCancellationRequested && piston)
                {
                    if (FemapModel.feFileReadStep(Path + "/PISTON/Piston.stp") == zReturnCode.FE_OK)
                    {
                        FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(),
                            zColor.FCL_STEELBLUE, 0, 1, 1);
                        Status.ProgressValue = 20;
                    }
                }

                if (!cts.IsCancellationRequested && rod)
                {
                    if (FemapModel.feFileReadStep(Path + "/ROD/Rod.stp") == zReturnCode.FE_OK)
                    {
                        FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(),
                            zColor.FCL_AVOCADO, 0, 1, 1);
                        FemapModel.feViewAutoscaleAll(1, true);
                        FemapModel.feViewRegenerate(0);
                        Status.ProgressValue = 40;
                    }
                }
                if (!cts.IsCancellationRequested && finger)
                {
                    if (FemapModel.feFileReadStep(Path + "/FINGER/Finger.stp") == zReturnCode.FE_OK)
                    {
                        FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(),
                            zColor.FCL_ORANGE, 0, 1, 1);
                        FemapModel.feViewAutoscaleAll(1, true);
                        FemapModel.feViewRegenerate(0);
                        Status.ProgressValue = 60;
                    }
                }
                if (!cts.IsCancellationRequested && coverRod)
                {
                    if (FemapModel.feFileReadStep(Path + "/COVER/CoverRod.stp") == zReturnCode.FE_OK)
                    {
                        FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(),
                            zColor.FCL_AVOCADO, 0, 1, 1);

                        Point point = FemapModel.fePoint;
                        point.x = -list.First(VARIABLE => VARIABLE.Id == "l3").Value;
                        FemapModel.feMoveBy(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(), false, -point.x, point.xyz);

                        FemapModel.feViewAutoscaleAll(1, true);
                        FemapModel.feViewRegenerate(0);
                        Status.ProgressValue = 80;
                    }
                }
                if (!cts.IsCancellationRequested && cylinder)
                {
                    if (FemapModel.feFileReadStep(Path + "/SLEEVE/SleeveCylinder.stp") == zReturnCode.FE_OK)
                    {
                        FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(),
                            zColor.FCL_GOLDENROD, 0, 1, 1);
                        Point points = FemapModel.fePoint;
                        points.x = list.First(VARIABLE => VARIABLE.Id == "l3").Value / 2;
                        FemapModel.feMoveBy(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(), false, points.x, points.xyz);
                        FemapModel.feViewAutoscaleAll(1, true);
                        FemapModel.feViewRegenerate(0);
                        Status.ProgressValue = 90;
                    }
                }
                if (!cts.IsCancellationRequested && crankshaft)
                {
                    if (FemapModel.feFileReadStep(Path + "/CRANKSHAFT/Crankshaft.stp") == zReturnCode.FE_OK)
                    {
                        FemapModel.feModifyColorMultiple(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(),
                            zColor.FCL_GRAY110, 0, 1, 1);
                        Point point = FemapModel.fePoint;
                        point.x = -list.First(VARIABLE => VARIABLE.Id == "l3").Value;
                        FemapModel.feMoveBy(zDataType.FT_SOLID, -FemapModel.feSolid.CountSet(), false, -point.x, point.xyz);
                        FemapModel.feViewAutoscaleAll(1, true);
                        FemapModel.feViewRegenerate(0);
                        Status.ProgressValue = 100;
                    }
                    Status.CurrState = Status.CurrentState.SAVING;
                    FemapModel.Pref_WorkplaneNotVisible = true;
                    FemapModel.feViewRegenerate(1);
                    FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/Assembly.modfem");
                }
                Status.CurrState = Status.CurrentState.READY;
                Status.ProgressValue = 0;
                await Task.Delay(500, cts);
                Status.CancellationTokenSourse = new CancellationTokenSource();
            }
        }

        public void CancelTask()
        {
            Status.CancellationTokenSourse.Cancel();
        }
    }
}
