using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using femap;
using Point = femap.Point;

namespace SPMAC_for_Femap.Classes
{
    internal class MakeDetails : ICancelModelling
    {
        private readonly model FemapModel;

        public MakeDetails(model FemapModel)
        {
            this.FemapModel = FemapModel;
            FemapModel.Pref_WorkplaneNotVisible = true;
        }

        public void CancelTask()
        {
            Status.CancellationTokenSourse.Cancel();
        }

        #region Details

        //Гильза цилиндра

        public async Task CreateSleeveAsync(CancellationToken cts)
        {
            Point[] points = new Point[200];
            if (!cts.IsCancellationRequested)
            {
                Status.CurrState = Status.CurrentState.CREATING;
                FemapModel.feFileNew();
                new SyncGUI(FemapModel).View();

                for (int i = 0; i <= 20; i++)
                    points[i] = FemapModel.fePoint;
                points[1].x = -Sizes.Value("l19");
                points[1].y = Sizes.Value("d6") / 2;
                points[2].y = Sizes.Value("d6") / 2;
                points[3].y = Sizes.Value("d15") / 2;
                points[4].x = -Sizes.Value("l20");
                points[4].y = Sizes.Value("d15") / 2;
                points[5].x = -Sizes.Value("l20");
                points[5].y = Sizes.Value("d16") / 2;
                points[6].x = -Sizes.Value("l21");
                points[6].y = Sizes.Value("d16") / 2;
                points[7].x = -Sizes.Value("l21");
                points[7].y = Sizes.Value("d17") / 2;
                points[8].x = -Sizes.Value("l22");
                points[8].y = Sizes.Value("d17") / 2;
                points[9].x = -Sizes.Value("l22");
                points[9].y = Sizes.Value("d16") / 2;
                points[10].x = -Sizes.Value("l19");
                points[10].y = Sizes.Value("d16") / 2;
                points[11].z = 1;
                points[12].x = 1;
                for (int i = 1; i <= 9; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feLinePoints(true, points[1].xyz, points[10].xyz, true);
                Status.ProgressValue = 25;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.AddRange(0, 11, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidRevolve(0, 1, 0, 2, points[0].xyz, points[12].xyz, points[11].xyz);
                FemapModel.feViewAutoscaleAll(0, true);
                Status.ProgressValue = 50;
            }

            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.AddRange(21, 22, 1);
                feSet.AddRange(39, 40, 1);
                feSet.AddRange(23, 24, 1);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r31"));

                feSet = FemapModel.feSet;
                feSet.AddRange(29, 30, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r32"));
                Status.ProgressValue = 75;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.AddRange(35, 36, 1);
                feSet.AddRange(33, 34, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r33"));

                feSet = FemapModel.feSet;
                feSet.AddRange(27, 28, 1);
                feSet.AddRange(31, 32, 1);
                feSet.AddRange(37, 38, 1);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r31"));

                Status.ProgressValue = 100;
                Status.CurrState = Status.CurrentState.SAVING;
                FemapModel.feViewRegenerate(0);
                FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/SLEEVE/SleeveCylinder.modfem");
                FemapModel.feFileWriteStep(Status.CurrentDetailsSetDirectory + "/SLEEVE/SleeveCylinder.stp", -1);
            }

            Status.CurrState = Status.CurrentState.READY;
            Status.ProgressValue = 0;
            await Task.Delay(500, cts);
            Status.CancellationTokenSourse = new CancellationTokenSource();
            FemapModel.feAppMessage(zMessageColor.FCM_WARNING, Status.CurrentStatusString);
        }

        // Коленчатый вал

        public
        async Task CreateCrankshaftAsync(CancellationToken cts)
        {
            Point[] points = new Point[200];
            if (!cts.IsCancellationRequested)
            {
                Status.CurrState = Status.CurrentState.CREATING;
                FemapModel.feFileNew();
                new SyncGUI(FemapModel).View();
                FemapModel.set_Info_WorkplaneOrigin(2, 1);
                Set feSet = FemapModel.feSet;
                for (int i = 0; i <= 20; i++)
                    points[i] = FemapModel.fePoint;
                points[0].z = 1;
                points[1].z = Sizes.Value("h3") / 2;
                FemapModel.feCircleCenter(Sizes.Value("d3") / 2, points[0].xyz, true);
                FemapModel.feBoundaryFromCurves(-1);
                FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[1].xyz);
                FemapModel.set_Info_WorkplaneOrigin(2, Sizes.Value("h3") / 2);
                points[2].z = Sizes.Value("h6") / 2;
                points[3].z = -Sizes.Value("h3") / 2;
                FemapModel.feCircleCenter(Sizes.Value("r24") / 2, points[0].xyz, true);
                FemapModel.feBoundaryFromCurves(-8);
                FemapModel.feSolidExtrude(0, 6, 0, 1, points[1].xyz, points[2].xyz);
                FemapModel.feGenerateReflect(zDataType.FT_SOLID, -2, points[0].xyz, points[3].xyz, 0, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(1, 3, 1);
                Status.ProgressValue = 10;
                FemapModel.feSolidAdd(feSet.ID, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(4, 7, 1);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r6"));
                feSet = FemapModel.feSet;
                feSet.Add(14);
                feSet.Add(13);
                feSet.Add(20);
                feSet.Add(19);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r25"));
                FemapModel.set_Info_WorkplaneOrigin(2, Sizes.Value("h6") / 2);
                FemapModel.feViewAutoscaleAll(0, true);
                Status.ProgressValue = 30;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                points[7].y = Sizes.Value("h6");
                points[8].x = -Sizes.Value("r24") / 2;
                points[9].x = -Sizes.Value("r26") / 2;
                points[9].y = Sizes.Value("h6");
                FemapModel.feArcAngleCenterStart(180, points[6].xyz, points[8].xyz, true);
                FemapModel.feArcAngleCenterStart(-180, points[7].xyz, points[9].xyz, true);
                object[] pointArcXYZ = new object[20];
                FemapModel.feCoordOnPoint(42, out pointArcXYZ[3]);
                FemapModel.feCoordOnPoint(38, out pointArcXYZ[4]);
                FemapModel.feLinePoints(true, pointArcXYZ[3], pointArcXYZ[4], true);
                FemapModel.feCoordOnPoint(44, out pointArcXYZ[5]);
                FemapModel.feCoordOnPoint(40, out pointArcXYZ[6]);
                FemapModel.feLinePoints(true, pointArcXYZ[5], pointArcXYZ[6], true);
                feSet.AddRange(41, 44, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                points[10].z = Sizes.Value("h6") / 2;
                points[11].z = Sizes.Value("h6") / 2 + Sizes.Value("h7");
                FemapModel.feSolidExtrude(0, 23, 0, 1, points[10].xyz, points[11].xyz);
                FemapModel.feGenerateReflect(zDataType.FT_SOLID, -4, points[0].xyz, points[3].xyz, 0, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(1, 10, 1);
                FemapModel.feSolidAdd(feSet.ID, true);
                Status.ProgressValue = 40;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                points[12].z = Sizes.Value("h6") / 2 + Sizes.Value("h7");
                points[13].z = Sizes.Value("h8");
                FemapModel.set_Info_WorkplaneOrigin(2, Sizes.Value("h6") / 2 + Sizes.Value("h7"));
                FemapModel.feCircleCenter(Sizes.Value("r24") / 2, points[7].xyz, true);
                FemapModel.feBoundaryFromCurves(-69);
                FemapModel.feSolidExtrude(0, 36, 0, 1, points[12].xyz, points[13].xyz);
                FemapModel.feGenerateReflect(zDataType.FT_SOLID, -6, points[0].xyz, points[3].xyz, 0, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(1, 10, 1);
                FemapModel.feSolidAdd(feSet.ID, true);
                feSet.Add(73);
                feSet.Add(72);
                feSet.Add(79);
                feSet.Add(78);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r25"));
                Status.ProgressValue = 60;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                FemapModel.set_Info_WorkplaneOrigin(2, Sizes.Value("h8"));
                FemapModel.feCircleCenter(Sizes.Value("d13") / 2, points[7].xyz, true);
                FemapModel.feBoundaryFromCurves(-90);
                points[14].z = Sizes.Value("h8");
                points[15].z = Sizes.Value("h9");
                FemapModel.feSolidExtrude(0, 49, 0, 1, points[14].xyz, points[15].xyz);
                FemapModel.feGenerateReflect(zDataType.FT_SOLID, -8, points[0].xyz, points[3].xyz, 0, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(1, 10, 1);
                FemapModel.feSolidAdd(feSet.ID, true);
                Status.ProgressValue = 70;
                feSet.Add(96);
                feSet.Add(95);
                feSet.Add(101);
                feSet.Add(102);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r6"));

                FemapModel.set_Info_WorkplaneOrigin(2, 0);
                Status.ProgressValue = 80;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;

                FemapModel.set_Info_WorkplaneOrigin(2, Sizes.Value("h9"));
                FemapModel.feCircleCenter(Sizes.Value("d14"), points[7].xyz, true);
                feSet.Add(175);
                points[19].z = Sizes.Value("h10") / 2;
                points[19].y = Sizes.Value("h6");
                points[20].z = Sizes.Value("h9");
                FemapModel.feBoundaryFromCurves(-115);
                FemapModel.feSolidExtrude(0, 62, 0, 1, points[20].xyz, points[19].xyz);

                FemapModel.feGenerateReflect(zDataType.FT_SOLID, -10, points[0].xyz, points[3].xyz, 0, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(1, 20, 1);
                FemapModel.feSolidAdd(feSet.ID, true);
                Status.ProgressValue = 90;

                feSet = FemapModel.feSet;
                feSet.Add(125);
                feSet.Add(124);
                feSet.Add(118);
                feSet.Add(119);

                feSet.Add(99);
                feSet.Add(100);
                feSet.Add(93);
                feSet.Add(94);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r27"));

                feSet = FemapModel.feSet;
                feSet.Add(127);
                feSet.Add(126);
                feSet.Add(120);
                feSet.Add(121);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r28"));

                feSet = FemapModel.feSet;
                feSet.AddRange(45, 48, 1);
                feSet.AddRange(57, 60, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r29"));

                feSet = FemapModel.feSet;
                feSet.AddRange(45, 48, 1);
                feSet.AddRange(57, 60, 1);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r30"));

                feSet = FemapModel.feSet;
                feSet.AddRange(49, 52, 1);
                feSet.AddRange(54, 56, 1);
                feSet.AddRange(61, 64, 1);
                feSet.AddRange(66, 68, 1);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r30"));

                points[16].z = 1;
                FemapModel.feRotateBy(zDataType.FT_SOLID, -1, points[17].xyz, points[16].xyz, 90, 0);

                Status.ProgressValue = 100;
                Status.CurrState = Status.CurrentState.SAVING;
                FemapModel.feViewRegenerate(0);
                FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/CRANKSHAFT/Crankshaft.modfem");
                FemapModel.feFileWriteStep(Status.CurrentDetailsSetDirectory + "/CRANKSHAFT/Crankshaft.stp", -1);
            }
            Status.CurrState = Status.CurrentState.READY;
            Status.ProgressValue = 0;
            await Task.Delay(500, cts);
            Status.CancellationTokenSourse = new CancellationTokenSource();
            FemapModel.feAppMessage(zMessageColor.FCM_WARNING, Status.CurrentStatusString);
        }

        // Крышка шатуна

        public async Task CreateCoverRodAsync(CancellationToken cts)
        {
            Point[] points = new Point[500];
            cts.ThrowIfCancellationRequested();
            if (!cts.IsCancellationRequested)
            {
                Status.CurrState = Status.CurrentState.CREATING;
                FemapModel.feFileNew();
                new SyncGUI(FemapModel).View();
                FemapModel.set_Info_WorkplaneOrigin(2, 1);
                Set feSet = FemapModel.feSet;
                for (int i = 0; i <= 20; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = 0;
                points[1].x = 0;
                points[1].y = Sizes.Value("d3") / 2;
                points[2].x = 0;
                points[2].y = Sizes.Value("b3") / 2;
                points[3].x = -Sizes.Value("l4");
                points[3].y = Sizes.Value("b3") / 2;
                points[4].x = -Sizes.Value("l4");
                points[4].y = Sizes.Value("b3");
                points[5].x = -Sizes.Value("d2");
                points[6].x = -Sizes.Value("b3");
                points[6].y = (Sizes.Value("l10") - Sizes.Value("d2"));
                points[7].z = Sizes.Value("h3") / 2;
                points[8].z = Sizes.Value("l12") / 2;
                points[9].x = -(Sizes.Value("l10") - Sizes.Value("d2"));
                points[12].x = -Sizes.Value("l5") +
                               Sizes.Value("l4");
                points[12].y = Sizes.Value("b3") / 2;
                points[13].x = -Sizes.Value("l5") +
                               Sizes.Value("l4");
                points[13].y = Sizes.Value("b3");
                points[14].z = Sizes.Value("h2") / 2;

                for (int i = 1; i <= 3; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feArcAngleCenterStart(90, points[0].xyz, points[1].xyz, true);
                object[] pointArcXYZ = new object[20];
                FemapModel.feCoordOnPoint(10, out pointArcXYZ[0]);
                FemapModel.feLinePoints(true, pointArcXYZ[0], points[5].xyz, true);
                FemapModel.feArcAngleCenterStart(-90, points[0].xyz, points[5].xyz, true);
                FemapModel.feCurveJoin(3, 6, points[6].xyz, true, true);
                feSet.AddRange(1, 6, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[7].xyz);
                FemapModel.feViewAutoscaleAll(0, true);
                FemapModel.feViewRegenerate(0);
                Status.ProgressValue = 10;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                object[] pointArcXYZ = new object[20];
                FemapModel.feCoordOnPoint(26, out pointArcXYZ[1]);
                FemapModel.feCoordOnPoint(28, out pointArcXYZ[2]);
                FemapModel.feArcCenterStartEnd(points[9].xyz, pointArcXYZ[1], pointArcXYZ[2], true);
                FemapModel.feCoordOnPoint(34, out pointArcXYZ[3]);
                FemapModel.feLinePoints(true, pointArcXYZ[2], pointArcXYZ[3], true);
                FemapModel.feArcCenterStartEnd(points[0].xyz, pointArcXYZ[1], pointArcXYZ[3], true);
                feSet.AddRange(25, 27, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(0, 10, 2, 1, points[0].xyz, points[8].xyz);
                feSet.AddRange(1, 2, 1);
                FemapModel.feSolidAdd(feSet.ID, true);

                FemapModel.feArcCenterStartEnd(points[9].xyz, pointArcXYZ[1], pointArcXYZ[2], true);
                FemapModel.feCoordOnPoint(24, out pointArcXYZ[4]);
                FemapModel.feLinePoints(true, pointArcXYZ[4], points[12].xyz, true);
                FemapModel.feLinePoints(true, pointArcXYZ[4], pointArcXYZ[1], true);
                FemapModel.feLinePoints(true, points[12].xyz, points[13].xyz, true);
                FemapModel.feCurveJoin(42, 39, points[1].xyz, true, true);
                feSet.AddRange(39, 42, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(1, 17, 2, 1, points[0].xyz, points[14].xyz);
                Status.ProgressValue = 25;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                FemapModel.set_Info_WorkplaneOrigin(2, 0);
                //righttrianglecut
                WorkPlane(false, 8, 0, 0, 1);
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                points[0].z = Sizes.Value("l9") / 2 + 1;
                points[0].y = Sizes.Value("b3") / 2;
                points[1].z = Sizes.Value("h3") / 2;
                points[1].y = Sizes.Value("b3") / 2;
                points[2].z = Sizes.Value("h3") / 2;
                points[2].y = Sizes.Value("b6") / 2;
                points[3].z = -Sizes.Value("h3") / 2 + 2;
                points[3].y = Sizes.Value("b6") / 2;
                points[4].z = -Sizes.Value("l9") / 2 + 1;
                points[4].y = Sizes.Value("b3") / 2;
                points[5].z = -Sizes.Value("h3") / 2 + 2;
                points[5].y = Sizes.Value("b3") / 2;
                FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
                FemapModel.feLinePoints(true, points[1].xyz, points[2].xyz, true);
                FemapModel.feLinePoints(true, points[2].xyz, points[0].xyz, true);
                FemapModel.feLinePoints(true, points[3].xyz, points[4].xyz, true);
                FemapModel.feLinePoints(true, points[4].xyz, points[5].xyz, true);
                FemapModel.feLinePoints(true, points[5].xyz, points[3].xyz, true);
                feSet.AddRange(55, 57, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 22, 2, 2, points[0].xyz, points[1].xyz);
                feSet.AddRange(58, 60, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 24, 2, 2, points[0].xyz, points[1].xyz);
                Status.ProgressValue = 40;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                //bolt
                for (int i = 0; i <= 3; i++)
                    points[i] = FemapModel.fePoint;
                points[0].z = 1;
                points[0].y = Sizes.Value("b7") / 2;
                FemapModel.feCircleCenter(Sizes.Value("d4") / 2, points[0].xyz, true);
                feSet = FemapModel.feSet;
                feSet.Add(73);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 26, 2, 2, points[0].xyz, points[1].xyz);
                PreWorkPlane();
                Status.ProgressValue = 55;
            }
            if (!cts.IsCancellationRequested)
            {
                object[] pointArcXYZ = new object[20];
                Set feSet = FemapModel.feSet;
                FemapModel.set_Info_WorkplaneOrigin(2, 1);
                //in
                for (int i = 0; i <= 20; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = -Sizes.Value("l5") +
                              Sizes.Value("l4");
                points[0].y = Sizes.Value("b7") / 2;
                points[1].x = -Sizes.Value("l5") +
                              Sizes.Value("l4");
                points[1].y = Sizes.Value("b9") / 2;
                points[2].x = -Sizes.Value("l12");
                points[2].y = Sizes.Value("b9") / 2;
                points[3].x = -
                    (Sizes.Value("l11") - Sizes.Value("d3") / 2) -
                              Sizes.Value("d3") / 2;
                points[4].x = -
                    (Sizes.Value("l11") - Sizes.Value("d3") / 2) -
                              Sizes.Value("d3") / 2;
                points[4].y = Sizes.Value("b8") / 2;
                points[5].x = -
                    (Sizes.Value("l11") - Sizes.Value("d3") / 2) -
                              Sizes.Value("d3") / 2 - 30;
                points[6].x = -
                    (Sizes.Value("l11") - Sizes.Value("d3") / 2) -
                              Sizes.Value("d3") / 2 - 30;
                points[6].y = Sizes.Value("b7") / 2;
                points[7].z = Sizes.Value("h4") - Sizes.Value("h3") / 2;
                FemapModel.feCoordOnPoint(98, out pointArcXYZ[5]);
                FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
                FemapModel.feLinePoints(true, points[1].xyz, points[2].xyz, true);
                FemapModel.feLinePoints(true, points[4].xyz, points[3].xyz, true);
                FemapModel.feArcRadiusStartEnd(50, points[4].xyz, points[2].xyz, true);
                FemapModel.feLinePoints(true, points[3].xyz, points[5].xyz, true);
                FemapModel.feLinePoints(true, points[5].xyz, points[6].xyz, true);
                FemapModel.feLinePoints(true, points[6].xyz, points[0].xyz, true);
                feSet.AddRange(83, 89, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 29, 2, 1, points[0].xyz, points[7].xyz);
                FemapModel.set_Info_WorkplaneOrigin(2, 0);
                points[9].y = -1;
                FemapModel.feGenerateReflect(zDataType.FT_SOLID, -1, points[8].xyz, points[9].xyz, 0, true);
                feSet = FemapModel.feSet;
                feSet.AddRange(1, 3, 1);
                FemapModel.feSolidAdd(feSet.ID, true);
                FemapModel.feViewAutoscaleAll(0, true);
                FemapModel.feViewRegenerate(0);
                Status.ProgressValue = 75;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                //champher
                feSet = FemapModel.feSet;
                feSet.Add(18);
                feSet.Add(24);
                feSet.Add(79);
                feSet.Add(74);
                feSet.Add(109);
                feSet.Add(158);
                feSet.Add(156);
                feSet.Add(157);
                feSet.Add(78);
                feSet.Add(77);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r6"));

                feSet = FemapModel.feSet;
                feSet.Add(144);
                feSet.Add(141);
                feSet.Add(49);
                feSet.Add(53);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r11"));
                Status.ProgressValue = 85;
                feSet = FemapModel.feSet;
                feSet.Add(10);
                feSet.Add(37);
                feSet.Add(115);
                feSet.Add(114);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r11"));
                //rad
                feSet = FemapModel.feSet;
                feSet.Add(176);
                feSet.Add(175);
                feSet.Add(171);
                feSet.Add(170);
                feSet.Add(100);
                feSet.Add(101);
                feSet.Add(102);
                feSet.Add(105);
                feSet.Add(96);
                feSet.Add(97);
                feSet.Add(166);
                feSet.Add(167);
                feSet.Add(106);
                feSet.Add(107);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r14"));
                Status.ProgressValue = 90;
                feSet = FemapModel.feSet;
                feSet.Add(32);
                feSet.Add(35);
                feSet.Add(91);
                feSet.Add(92);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r15"));

                feSet = FemapModel.feSet;
                feSet.Add(33);
                feSet.Add(36);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r16"));

                FemapModel.feViewAutoscaleAll(0, true);
                FemapModel.feViewRegenerate(0);

                Status.ProgressValue = 100;
                Status.CurrState = Status.CurrentState.SAVING;
                FemapModel.feFileWriteStep(Status.CurrentDetailsSetDirectory + "/COVER/CoverRod.stp", -1);
                FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/COVER/CoverRod.modfem");
            }
            Status.CurrState = Status.CurrentState.READY;
            Status.ProgressValue = 0;
            await Task.Delay(500, cts);
            Status.CancellationTokenSourse = new CancellationTokenSource();
            FemapModel.feAppMessage(zMessageColor.FCM_WARNING, Status.CurrentStatusString);
        }

        // Шатун

        public async Task CreateConnectingRodAsync(CancellationToken cts)
        {
            Point[] points = new Point[1000];
            cts.ThrowIfCancellationRequested();
            if (!cts.IsCancellationRequested)
            {
                Status.CurrState = Status.CurrentState.CREATING;
                FemapModel.feFileNew();
                new SyncGUI(FemapModel).View();
                Status.ProgressValue = 5;
                //circle1 right
                for (int i = 0; i <= 1; i++)
                    points[i] = FemapModel.fePoint;
                points[1].z = Sizes.Value("h1") / 2;
                Set feSet = FemapModel.feSet;
                feSet.AddRange(1, 2, 1);
                FemapModel.feCircleCenter(Sizes.Value("d1") / 2, points[0].xyz, true);
                FemapModel.feCircleCenter(Sizes.Value("d2") / 2, points[0].xyz, true);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[1].xyz);
                Status.ProgressValue = 10;
            }
            if (!cts.IsCancellationRequested)
            {
                //centrertavr
                for (int i = 0; i <= 4; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = -Sizes.Value("l1");
                points[0].y = -Sizes.Value("b1") / 2 - 0.5;
                points[1].x = -Sizes.Value("l1");
                points[1].y = Sizes.Value("b1") / 2 + 0.5;
                points[2].x = -Sizes.Value("l3") + Sizes.Value("l2");
                points[2].y = Sizes.Value("b2") / 2 + 0.5;
                points[3].x = -Sizes.Value("l3") + Sizes.Value("l2");
                points[3].y = -Sizes.Value("b2") / 2 - 0.5;
                points[4].z = -Sizes.Value("h2") / 2 + 1;
                FemapModel.set_Info_WorkplaneOrigin(2, 1);
                for (int i = 0; i <= 2; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feLinePoints(true, points[0].xyz, points[3].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(15, 18, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(0, 8, 2, 1, points[0].xyz, points[4].xyz);
                FemapModel.feViewAutoscaleAll(0, true);
                Status.ProgressValue = 15;
            }
            if (!cts.IsCancellationRequested)
            {
                //left up arc
                for (int i = 0; i <= 11; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = -Sizes.Value("l3");
                points[1].x = -Sizes.Value("l3");
                points[1].y = Sizes.Value("d3") / 2;
                points[2].x = -Sizes.Value("l3");
                points[2].y = Sizes.Value("b3") / 2;
                points[3].x = -Sizes.Value("l3") + Sizes.Value("l4");
                points[3].y = Sizes.Value("b3") / 2;
                points[4].x = -Sizes.Value("l3") + Sizes.Value("l4");
                points[4].y = Sizes.Value("r1") - 0.25;
                points[5].x = -Sizes.Value("l3");
                points[5].y = -Sizes.Value("d3") / 2;
                points[6].x = -Sizes.Value("l3");
                points[6].y = -Sizes.Value("b3") / 2;
                points[7].x = -Sizes.Value("l3") + Sizes.Value("l4");
                points[7].y = -Sizes.Value("b3") / 2;
                points[8].x = -Sizes.Value("l3") + Sizes.Value("l4");
                points[8].y = -Sizes.Value("r1") + 0.25;
                points[10].z = Sizes.Value("h3") / 2;
                FemapModel.feArcAngleCenterStart(-180, points[0].xyz, points[1].xyz, true);
                for (int i = 1; i <= 3; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                for (int i = 5; i <= 7; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feArcRadiusStartEnd(Sizes.Value("r1"), points[8].xyz, points[4].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(31, 38, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(1, 15, 2, 1, points[0].xyz, points[10].xyz);
                Status.ProgressValue = 20;
            }
            if (!cts.IsCancellationRequested)
            {
                //add to surfase
                for (int i = 0; i <= 2; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = -Sizes.Value("l3") + Sizes.Value("l2");
                points[1].x = -Sizes.Value("l3") + Sizes.Value("d3") / 2;
                points[2].x = -Sizes.Value("l1");
                points[3].x = -Sizes.Value("d1") / 2 - 0.5;
                FemapModel.feSolidExtrude(1, 12, 0, 1, points[0].xyz, points[1].xyz);
                FemapModel.feSolidExtrude(1, 10, 0, 1, points[2].xyz, points[3].xyz);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(1, 3, 1);
                FemapModel.feSolidAdd(feSet.ID, true);

                //big degree
                feSet = FemapModel.feSet;
                feSet.AddRange(88, 89, 1);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r3"));
                feSet.AddRange(94, 95, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r2"));
                feSet.AddRange(96, 97, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r3"));
                Status.ProgressValue = 25;
            }
            if (!cts.IsCancellationRequested)
            {
                //left arc center
                for (int i = 0; i <= 8; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = -Sizes.Value("l3");
                points[1].x = -Sizes.Value("l3");
                points[1].y = Sizes.Value("d3") / 2;
                points[2].x = -Sizes.Value("l3");
                points[2].y = Sizes.Value("b3") / 2;
                points[3].x = -Sizes.Value("l3") + Sizes.Value("l5");
                points[3].y = Sizes.Value("b3") / 2;
                points[4].x = -Sizes.Value("l3") + Sizes.Value("l5");
                points[4].y = Sizes.Value("d3") / 2;
                points[5].x = -Sizes.Value("l3") + Sizes.Value("l6");
                points[5].y = Sizes.Value("d3") / 2;
                points[6].z = -(Sizes.Value("h2") / 2) + 1;
                points[7].y = -1;
                for (int i = 1; i <= 4; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(114, 117, 1);
                FemapModel.feGenerateReflect(zDataType.FT_CURVE, feSet.ID, points[0].xyz, points[7].xyz, 0, false);
                object[] point = new object[10];
                FemapModel.feCoordOnPoint(111, out point[0]);
                FemapModel.feCoordOnPoint(126, out point[1]);
                FemapModel.feCoordOnPoint(119, out point[2]);
                FemapModel.feCoordOnPoint(118, out point[3]);
                FemapModel.feArcCenterStartEnd(points[0].xyz, point[1], point[3], true);
                FemapModel.feArcCenterStartEnd(points[0].xyz, point[2], point[0], true);
                feSet.AddRange(114, 124, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(1, 39, 2, 1, points[0].xyz, points[6].xyz);
                Status.ProgressValue = 30;
            }
            if (!cts.IsCancellationRequested)
            {
                //60 radius left arc
                Set feSet = FemapModel.feSet;
                feSet.Add(135);
                feSet.Add(124);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r4"));
                feSet.Add(82);
                feSet.Add(79);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r5"));
                Status.ProgressValue = 35;
            }
            if (!cts.IsCancellationRequested)
            {
                //right out hole
                FemapModel.set_Info_WorkplaneOrigin(2, 0);
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = Sizes.Value("d1") / 2 + 1;
                points[0].y = Sizes.Value("b4") / 2;
                points[1].x = Sizes.Value("l7");
                points[1].y = Sizes.Value("b4") / 2;
                points[2].x = Sizes.Value("l7");
                points[2].y = -Sizes.Value("b4") / 2;
                points[3].x = Sizes.Value("d1") / 2 + 1;
                points[3].y = -Sizes.Value("b4") / 2;
                points[4].z = Sizes.Value("h1") / 2;
                points[5].z = 0;
                for (int i = 0; i <= 2; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feLinePoints(true, points[3].xyz, points[0].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(184, 187, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(1, 60, 2, 1, points[5].xyz, points[4].xyz);
                Status.ProgressValue = 40;
            }
            if (!cts.IsCancellationRequested)
            {
                //center cut out
                FemapModel.set_Info_WorkplaneOrigin(2, 1);
                for (int i = 0; i <= 7; i++)
                    points[i] = FemapModel.fePoint;
                points[0].x = -Sizes.Value("l3") + Sizes.Value("d3") / 2 +
                              Sizes.Value("l4") + Sizes.Value("b2") /
                              2 - Sizes.Value("b5") + 1;
                points[0].y = Sizes.Value("b2") / 2 -
                              Sizes.Value("b5");
                points[0].z = Sizes.Value("h2") / 2;
                points[1].x = -Sizes.Value("l1");
                points[1].y = Sizes.Value("b1") / 2 -
                              Sizes.Value("b5");
                points[1].z = Sizes.Value("h2") / 2;
                points[2].z = Sizes.Value("l8") / 2 + 1;
                points[3].x = -Sizes.Value("l1");
                points[3].y = -Sizes.Value("b1") /
                              2 + Sizes.Value("b5");
                points[3].z = Sizes.Value("h2") / 2;
                points[4].x = -Sizes.Value("l3") + Sizes.Value("d3") / 2 +
                              Sizes.Value("l4") + Sizes.Value("b2") / 2 -
                              Sizes.Value("b5") + 1;
                points[4].y = -Sizes.Value("b2") / 2 +
                              Sizes.Value("b5");
                points[4].z = Sizes.Value("h2") / 2;
                points[5].z = 1;
                points[6].z = -Sizes.Value("h2") / 2;
                points[7].z = -Sizes.Value("l8") / 2 + 1;
                FemapModel.set_Info_WorkplaneOrigin(2, Sizes.Value("h2") / 2 + 1);
                FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
                FemapModel.feLinePoints(true, points[3].xyz, points[4].xyz, true);
                FemapModel.feArcAngleStartEnd(180, points[0].xyz, points[4].xyz, true);
                FemapModel.feArcAngleStartEnd(180, points[3].xyz, points[1].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(198, 201, 1);
                FemapModel.feGenerateReflect(zDataType.FT_CURVE, feSet.ID, points[5].xyz, points[6].xyz, 0, true);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 64, 2, 1, points[0].xyz, points[2].xyz);
                feSet.AddRange(202, 205, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 71, 2, 1, points[6].xyz, points[7].xyz);
                FemapModel.set_Info_WorkplaneOrigin(2, 0);
                Status.ProgressValue = 45;
            }
            if (!cts.IsCancellationRequested)
            {
                //right triangle cut
                WorkPlane(false, 39, -Sizes.Value("l3"), 0, 1);
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                points[0].z = Sizes.Value("l9") / 2 + 1;
                points[0].y = Sizes.Value("b3") / 2;
                points[1].z = Sizes.Value("h3") / 2;
                points[1].y = Sizes.Value("b3") / 2;
                points[2].z = Sizes.Value("h3") / 2;
                points[2].y = Sizes.Value("b6") / 2;
                points[3].z = -Sizes.Value("h3") / 2 + 2;
                points[3].y = Sizes.Value("b6") / 2;
                points[4].z = -Sizes.Value("l9") / 2 + 1;
                points[4].y = Sizes.Value("b3") / 2;
                points[5].z = -Sizes.Value("h3") / 2 + 2;
                points[5].y = Sizes.Value("b3") / 2;
                FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
                FemapModel.feLinePoints(true, points[1].xyz, points[2].xyz, true);
                FemapModel.feLinePoints(true, points[2].xyz, points[0].xyz, true);
                FemapModel.feLinePoints(true, points[3].xyz, points[4].xyz, true);
                FemapModel.feLinePoints(true, points[4].xyz, points[5].xyz, true);
                FemapModel.feLinePoints(true, points[5].xyz, points[3].xyz, true);
                points[6].z = Sizes.Value("l9") / 2 + 1;
                points[6].y = -Sizes.Value("b3") / 2;
                points[7].z = Sizes.Value("h3") / 2;
                points[7].y = -Sizes.Value("b3") / 2;
                points[8].z = Sizes.Value("h3") / 2;
                points[8].y = -Sizes.Value("b6") / 2;
                points[9].z = -Sizes.Value("h3") / 2 + 2;
                points[9].y = -Sizes.Value("b6") / 2;
                points[10].z = -Sizes.Value("l9") / 2 + 1;
                points[10].y = -Sizes.Value("b3") / 2;
                points[11].z = -Sizes.Value("h3") / 2 + 2;
                points[11].y = -Sizes.Value("b3") / 2;
                FemapModel.feLinePoints(true, points[6].xyz, points[7].xyz, true);
                FemapModel.feLinePoints(true, points[7].xyz, points[8].xyz, true);
                FemapModel.feLinePoints(true, points[8].xyz, points[6].xyz, true);
                FemapModel.feLinePoints(true, points[9].xyz, points[10].xyz, true);
                FemapModel.feLinePoints(true, points[10].xyz, points[11].xyz, true);
                FemapModel.feLinePoints(true, points[11].xyz, points[9].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(245, 247, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 78, 2, 1, points[6].xyz, points[7].xyz);
                feSet.AddRange(242, 244, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 80, 2, 1, points[6].xyz, points[7].xyz);
                feSet.AddRange(251, 253, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 82, 2, 1, points[6].xyz, points[7].xyz);
                feSet.AddRange(248, 250, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 84, 2, 1, points[6].xyz, points[7].xyz);
                Status.ProgressValue = 50;
            }
            if (!cts.IsCancellationRequested)
            {
                //bolt cut
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                points[0].z = 1;
                points[0].y = Sizes.Value("b7") / 2;
                points[1].z = 1;
                points[1].y = -Sizes.Value("b7") / 2;
                FemapModel.feCircleCenter(Sizes.Value("d4") / 2, points[0].xyz, true);
                FemapModel.feCircleCenter(Sizes.Value("d4") / 2, points[1].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.Add(278);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 86, 2, 1, points[6].xyz, points[7].xyz);
                feSet.Add(279);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 89, 2, 1, points[6].xyz, points[7].xyz);
                PreWorkPlane();
                Status.ProgressValue = 55;
            }
            if (!cts.IsCancellationRequested)
            {
                //chamfer
                Set feSet = FemapModel.feSet;
                feSet.Add(10);
                feSet.Add(9);
                feSet.Add(13);
                feSet.Add(14);
                feSet.Add(54);
                feSet.Add(62);
                feSet.Add(286);
                feSet.Add(287);
                feSet.Add(289);
                feSet.Add(288);
                feSet.Add(283);
                feSet.Add(282);
                feSet.Add(280);
                feSet.Add(281);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r6"));
                Status.ProgressValue = 60;
                feSet = FemapModel.feSet;
                feSet.AddRange(238, 241, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r7"));
                feSet.AddRange(220, 223, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r7"));
                Status.ProgressValue = 65;
                feSet = FemapModel.feSet;
                feSet.Add(81);
                feSet.Add(85);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r8"));
                Status.ProgressValue = 70;
                feSet = FemapModel.feSet;
                feSet.Add(80);
                feSet.Add(84);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r9"));
                Status.ProgressValue = 75;
                feSet = FemapModel.feSet;
                feSet.Add(213);
                feSet.Add(212);
                feSet.Add(207);
                feSet.Add(208);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r10"));
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.Add(230);
                feSet.Add(231);
                feSet.Add(225);
                feSet.Add(226);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r10"));
                Status.ProgressValue = 80;
                feSet = FemapModel.feSet;
                feSet.Add(188);
                feSet.Add(189);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r12"));

                feSet = FemapModel.feSet;
                feSet.Add(149);
                feSet.Add(152);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r13"));
                Status.ProgressValue = 85;
                feSet = FemapModel.feSet;
                feSet.Add(137);
                feSet.Add(138);
                feSet.Add(140);
                feSet.Add(141);
                feSet.Add(147);
                feSet.Add(146);
                feSet.Add(144);
                feSet.Add(143);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r11"));
                Status.ProgressValue = 90;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.Add(136);
                feSet.Add(142);
                feSet.Add(139);
                feSet.Add(145);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r13"));

                feSet.Add(99);
                feSet.Add(101);
                feSet.Add(541);
                feSet.Add(543);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r13"));
                Status.ProgressValue = 98;
                feSet = FemapModel.feSet;
                feSet.AddRange(170, 173, 1);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r10"));
                FemapModel.Pref_WorkplaneNotVisible = true;
                FemapModel.feViewAutoscaleAll(0, true);
                FemapModel.feViewRegenerate(0);
                Status.ProgressValue = 100;
                Status.CurrState = Status.CurrentState.SAVING;
                FemapModel.feFileWriteStep(Status.CurrentDetailsSetDirectory + "/ROD/Rod.stp", -1);
                FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/ROD/Rod.modfem");
            }
            Status.CurrState = Status.CurrentState.READY;
            Status.ProgressValue = 0;
            await Task.Delay(500, cts);
            Status.CancellationTokenSourse = new CancellationTokenSource();
        }

        // Поршень

        public async Task CreatePistonAsync(CancellationToken cts)
        {
            cts.ThrowIfCancellationRequested();
            if (!cts.IsCancellationRequested)
            {
                Status.CurrState = Status.CurrentState.CREATING;

                FemapModel.feFileNew();
                new SyncGUI(FemapModel).View();
                Point[] points = new Point[25];

                for (int i = 0; i <= 20; i++)
                    points[i] = FemapModel.fePoint;
                points[1].x = Sizes.Value("l13");
                points[2].x = Sizes.Value("l13");
                points[2].y = Sizes.Value("d6") / 2;
                points[3].x = -Sizes.Value("l18") + Sizes.Value("l13");
                points[3].y = Sizes.Value("d6") / 2;
                points[4].x = -Sizes.Value("l18") + Sizes.Value("l13");
                points[4].y = Sizes.Value("d7") / 2;
                points[5].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l14");
                points[5].y = Sizes.Value("d7") / 2;
                points[6].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l14");
                points[6].y = Sizes.Value("d8") / 2;
                points[7].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l15");
                points[7].y = Sizes.Value("d8") / 2;
                points[8].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l15");
                points[8].y = Sizes.Value("d9") / 2;
                points[9].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l16");
                points[9].y = Sizes.Value("d9") / 2;
                points[10].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                               Sizes.Value("l16");
                points[10].y = Sizes.Value("d10") / 2;
                points[11].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                               Sizes.Value("l16") + Sizes.Value("l17");
                points[11].y = Sizes.Value("d10") / 2;
                points[12].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                               Sizes.Value("l16") + Sizes.Value("l17");
                points[13].x = 1;
                for (int i = 1; i <= 11; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feLinePoints(true, points[1].xyz, points[12].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(0, 12, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidRevolve(0, 1, 0, 2, points[0].xyz, points[1].xyz, points[13].xyz);
                FemapModel.feViewAutoscaleAll(0, true);
                Status.ProgressValue = 15;
            }
            if (!cts.IsCancellationRequested)
            {
                WorkPlane(false, 22, 0, 0, Sizes.Value("b10") / 2);
                Point[] points = new Point[20];
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                points[1].y = Sizes.Value("d1") / 2;
                points[2].y = Sizes.Value("b11") / 2;
                FemapModel.feArcAngleCenterStart(180, points[0].xyz, points[2].xyz, false);
                points[3].y = -Sizes.Value("b11") / 2;
                points[4].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l16") + Sizes.Value("l17");
                points[4].y = -Sizes.Value("b11") / 2;
                points[5].x = -Sizes.Value("l18") + Sizes.Value("l13") +
                              Sizes.Value("l16") + Sizes.Value("l17");
                points[5].y = Sizes.Value("b11") / 2;
                FemapModel.feLinePoints(true, points[2].xyz, points[5].xyz, true);
                FemapModel.feLinePoints(true, points[3].xyz, points[4].xyz, true);
                FemapModel.feLinePoints(true, points[5].xyz, points[4].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(43, 46, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                feSet = FemapModel.feSet;
                feSet.Add(18);
                points[6].z = -Sizes.Value("b10");
                FemapModel.feGenerateReflect(zDataType.FT_SURFACE, feSet.ID, points[0].xyz, points[6].xyz, 0, true);
                object[] point = new object[2];
                FemapModel.feCoordOnPoint(31, out point[0]);
                FemapModel.feSolidExtrude(1, 18, 0, 1, points[0].xyz, point[0]);
                FemapModel.feCoordOnPoint(29, out point[1]);
                FemapModel.feSolidExtrude(1, 19, 1, 1, points[0].xyz, point[1]);
                PreWorkPlane();
                FemapModel.feCircleRadius(points[0].xyz, points[1].xyz, false);
                feSet = FemapModel.feSet;
                feSet.Add(83);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 29, 2, 2, points[0].xyz, points[0].xyz);
                Status.ProgressValue = 30;
            }
            if (!cts.IsCancellationRequested)
            {
                Point[] points = new Point[20];
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                points[0].y = -Sizes.Value("b12") / 2;
                points[0].x = -Sizes.Value("l18") + Sizes.Value("l13");
                points[1].y = Sizes.Value("b12") / 2;
                points[1].x = -Sizes.Value("l18") + Sizes.Value("l13");
                FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
                object[] point = new object[2];
                FemapModel.feCoordOnPoint(101, out point[0]);
                FemapModel.feCoordOnPoint(100, out point[1]);
                FemapModel.feArcRadiusStartEnd(Sizes.Value("r18"), point[1], point[0], true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(98, 99, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                FemapModel.feSolidExtrude(2, 34, 2, 2, points[0].xyz, points[0].xyz);
                Status.ProgressValue = 45;
            }
            if (!cts.IsCancellationRequested)
            {
                Point[] points = new Point[20];
                object[] point = new object[2];
                for (int i = 0; i <= 10; i++)
                    points[i] = FemapModel.fePoint;
                FemapModel.feCoordOnPoint(110, out point[0]);
                points[0].xyz = point[0];
                WorkPlane(false, 120, points[0].x, 0, 0);
                points[1].z = Sizes.Value("b13") / 2;
                FemapModel.feCircleCenter(Sizes.Value("d11"), points[1].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.Add(136);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                points[2].z = -Sizes.Value("b13") / 2;
                feSet = FemapModel.feSet;
                feSet.Add(42);
                FemapModel.feGenerateReflect(zDataType.FT_SURFACE, feSet.ID, points[3].xyz, points[2].xyz, 0, true);
                FemapModel.feSolidExtrude(2, 42, 1, 1, points[0].xyz, points[3].xyz);
                FemapModel.feSolidExtrude(2, 43, 1, 1, points[0].xyz, points[3].xyz);
                PreWorkPlane();
                Status.ProgressValue = 55;
            }
            if (!cts.IsCancellationRequested)
            {
                Point[] points = new Point[25];

                for (int i = 0; i <= 20; i++)
                    points[i] = FemapModel.fePoint;
                points[1].x = Sizes.Value("l13");
                points[1].y = Sizes.Value("d6") / 2 + 10;
                points[2].x = Sizes.Value("l13");
                points[2].y = Sizes.Value("d6") / 2;
                points[3].x = Sizes.Value("l13") - Sizes.Value("b14");
                points[3].y = Sizes.Value("d6") / 2;
                points[4].x = Sizes.Value("l13") - Sizes.Value("b14");
                points[4].y = Sizes.Value("d12") / 2;
                points[5].x = Sizes.Value("l13") - Sizes.Value("b14") -
                              Sizes.Value("b15");
                points[5].y = Sizes.Value("d12") / 2;
                points[6].x = Sizes.Value("l13") - Sizes.Value("b14") -
                              Sizes.Value("b15");
                points[6].y = Sizes.Value("d6") / 2;
                points[7].x = Sizes.Value("l13") - Sizes.Value("b14") -
                              Sizes.Value("b15") - Sizes.Value("b18");
                points[7].y = Sizes.Value("d6") / 2;
                points[8].x = Sizes.Value("l13") - Sizes.Value("b14") -
                              Sizes.Value("b15") - Sizes.Value("b18");
                points[8].y = Sizes.Value("d12") / 2;
                points[9].x = Sizes.Value("l13") - Sizes.Value("b14") -
                              Sizes.Value("b15") - Sizes.Value("b18") -
                              Sizes.Value("b16");
                points[9].y = Sizes.Value("d12") / 2;
                points[10].x = Sizes.Value("l13") - Sizes.Value("b14") -
                               Sizes.Value("b15") - Sizes.Value("b18") -
                               Sizes.Value("b16");
                points[10].y = Sizes.Value("d6") / 2;
                points[11].x = Sizes.Value("l13") - Sizes.Value("b14") -
                               Sizes.Value("b15") - Sizes.Value("b18") -
                               Sizes.Value("b16") - Sizes.Value("b19");
                points[11].y = Sizes.Value("d6") / 2;
                points[12].x = Sizes.Value("l13") - Sizes.Value("b14") -
                               Sizes.Value("b15") - Sizes.Value("b18") -
                               Sizes.Value("b16") - Sizes.Value("b19");
                points[12].y = Sizes.Value("d12") / 2;
                points[13].x = Sizes.Value("l13") - Sizes.Value("b14") -
                               Sizes.Value("b15") - Sizes.Value("b18") -
                               Sizes.Value("b16") - Sizes.Value("b19") -
                               Sizes.Value("b17");
                points[13].y = Sizes.Value("d12") / 2;
                points[14].x = Sizes.Value("l13") - Sizes.Value("b14") -
                               Sizes.Value("b15") - Sizes.Value("b18") -
                               Sizes.Value("b16") - Sizes.Value("b19") -
                               Sizes.Value("b17");
                points[14].y = Sizes.Value("d6") / 2;

                for (int i = 1; i <= 13; i++)
                    FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
                FemapModel.feLinePoints(true, points[1].xyz, points[14].xyz, true);
                Set feSet = FemapModel.feSet;
                feSet.AddRange(152, 165, 1);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                points[15].y = 1;
                points[16].x = 1;
                FemapModel.feSolidRevolve(2, 48, 0, 2, points[17].xyz, points[16].xyz, points[15].xyz);
                Status.ProgressValue = 65;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.Add(23);
                feSet.Add(24);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r19"));

                feSet = FemapModel.feSet;
                feSet.Add(25);
                feSet.Add(26);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r20"));

                feSet = FemapModel.feSet;
                feSet.Add(88);
                feSet.Add(89);
                feSet.Add(91);
                feSet.Add(92);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r21"));

                feSet = FemapModel.feSet;
                feSet.Add(90);
                feSet.Add(93);
                feSet.Add(84);
                feSet.Add(85);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r21"));
                Status.ProgressValue = 75;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;

                feSet = FemapModel.feSet;
                feSet.Add(178);
                feSet.Add(179);
                feSet.Add(184);
                feSet.Add(185);
                feSet.Add(186);
                feSet.Add(187);
                feSet.Add(192);
                feSet.Add(193);
                feSet.Add(194);
                feSet.Add(195);
                feSet.Add(200);
                feSet.Add(201);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r22"));

                feSet = FemapModel.feSet;
                feSet.Add(145);
                feSet.Add(146);
                feSet.Add(138);
                feSet.Add(139);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r22"));

                feSet = FemapModel.feSet;
                feSet.Add(60);
                feSet.Add(61);
                feSet.Add(77);
                feSet.Add(76);
                feSet.Add(41);
                feSet.Add(203);
                feSet.Add(80);
                feSet.Add(64);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r23"));
                Status.ProgressValue = 85;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.Add(53);
                feSet.Add(58);
                feSet.Add(68);
                feSet.Add(70);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r23"));

                feSet = FemapModel.feSet;
                feSet.Add(39);
                feSet.Add(40);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r23"));

                feSet = FemapModel.feSet;
                feSet.Add(355);
                feSet.Add(359);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r23"));
                Status.ProgressValue = 95;
            }
            if (!cts.IsCancellationRequested)
            {
                Set feSet = FemapModel.feSet;
                feSet.Add(51);
                feSet.Add(52);
                feSet.Add(67);
                feSet.Add(69);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r23"));

                feSet = FemapModel.feSet;
                feSet.Add(82);
                feSet.Add(103);
                feSet.Add(66);
                feSet.Add(102);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r22"));

                feSet = FemapModel.feSet;
                feSet.Add(198);
                feSet.Add(196);
                feSet.Add(188);
                feSet.Add(180);
                feSet.Add(190);
                feSet.Add(182);
                FemapModel.feSolidFillet(feSet.ID, Sizes.Value("r22"));

                FemapModel.feViewAutoscaleAll(0, true);
                FemapModel.feViewRegenerate(0);
                Status.ProgressValue = 100;
                Status.CurrState = Status.CurrentState.SAVING;
                FemapModel.feFileWriteStep(Status.CurrentDetailsSetDirectory + "/PISTON/Piston.stp", -1);
                FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/PISTON/Piston.modfem");
            }

            Status.CurrState = Status.CurrentState.READY;
            Status.ProgressValue = 0;
            await Task.Delay(500, cts);
            Status.CancellationTokenSourse = new CancellationTokenSource();
        }

        // Поршневой палец

        public async Task CreatePistonFingerAsync(CancellationToken cts)
        {
            cts.ThrowIfCancellationRequested();
            if (!cts.IsCancellationRequested)
            {
                Status.CurrState = Status.CurrentState.CREATING;
                FemapModel.feFileNew();
                new SyncGUI(FemapModel).View();
                Set feSet = FemapModel.feSet;
                Point[] points = new Point[10];
                Status.ProgressValue = 20;
                for (int i = 0; i <= 3; i++)
                    points[i] = FemapModel.fePoint;
                points[1].z = Sizes.Value("h5") / 2;
                FemapModel.feCircleCenter(Sizes.Value("d1") / 2, points[0].xyz, true);
                FemapModel.feCircleCenter(Sizes.Value("d5") / 2, points[0].xyz, true);
                Status.ProgressValue = 40;
                feSet = FemapModel.feSet;
                feSet.Add(1);
                feSet.Add(2);
                FemapModel.feBoundaryFromCurves(feSet.ID);
                Status.ProgressValue = 60;
                FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[1].xyz);
                FemapModel.feViewRegenerate(0);
                feSet = FemapModel.feSet;
                Status.ProgressValue = 80;
                feSet.Add(8);
                feSet.Add(7);
                feSet.Add(12);
                feSet.Add(11);
                feSet.Add(9);
                feSet.Add(10);
                feSet.Add(14);
                feSet.Add(13);
                FemapModel.feSolidChamfer(feSet.ID, Sizes.Value("r17"));

                Status.ProgressValue = 100;
                Status.CurrState = Status.CurrentState.SAVING;
                FemapModel.feFileWriteStep(Status.CurrentDetailsSetDirectory + "/FINGER/Finger.stp", -1);
                FemapModel.feFileSaveAs(false, Status.CurrentDetailsSetDirectory + "/FINGER/Finger.modfem");
            }
            Status.CurrState = Status.CurrentState.READY;
            Status.ProgressValue = 0;
            await Task.Delay(500, cts);
            Status.CancellationTokenSourse = new CancellationTokenSource();
        }

        #endregion

        #region WorkPlane

        private void WorkPlane(bool onCurve, int cuID, double X, double Y, double Z)
        {
            Set cuSet = FemapModel.feSet;
            int ptID1, ptID2;
            double[] pt1Loc = new double[10];
            Curve feCurve = FemapModel.feCurve;
            Point fePoint = FemapModel.fePoint;
            object vpt1, v1, v2, v3;
            if (onCurve) cuSet.SelectID(zDataType.FT_CURVE, "Select Curve to Align CSys", out cuID);
            else cuSet.Add(cuID);

            if (cuID > 0)
            {
                feCurve.Get(cuID);
                feCurve.EndPoints(out ptID1, out ptID2);
                fePoint.Get(ptID1);
                if (onCurve)
                {
                    pt1Loc[0] = fePoint.x;
                    pt1Loc[1] = fePoint.y;
                    pt1Loc[2] = fePoint.z;
                }
                else
                {
                    pt1Loc[0] = X;
                    pt1Loc[1] = Y;
                    pt1Loc[2] = Z;
                }
                vpt1 = pt1Loc;
                feCurve.Tangent(false, vpt1, out v1);
                FemapModel.feVectorPerpendicular(v1, out v2);
                FemapModel.feVectorCrossProduct(v2, v1, out v3);
                if (onCurve)
                {
                    FemapModel.set_Info_WorkplaneOrigin(0, fePoint.x);
                    FemapModel.set_Info_WorkplaneOrigin(1, fePoint.y);
                    FemapModel.set_Info_WorkplaneOrigin(2, fePoint.z);
                }
                else
                {
                    FemapModel.set_Info_WorkplaneOrigin(0, X);
                    FemapModel.set_Info_WorkplaneOrigin(1, Y);
                    FemapModel.set_Info_WorkplaneOrigin(2, Z);
                }
                double[] d1 = (double[])v1;
                double[] d2 = (double[])v2;
                double[] d3 = (double[])v3;
                FemapModel.set_Info_WorkplaneX(0, -d1[0]);
                FemapModel.set_Info_WorkplaneX(1, -d1[1]);
                FemapModel.set_Info_WorkplaneX(2, -d1[2]);
                FemapModel.set_Info_WorkplaneY(0, d2[0]);
                FemapModel.set_Info_WorkplaneY(1, d2[1]);
                FemapModel.set_Info_WorkplaneY(2, d2[2]);
                FemapModel.set_Info_WorkplaneZ(0, d3[0]);
                FemapModel.set_Info_WorkplaneZ(1, d3[1]);
                FemapModel.set_Info_WorkplaneZ(2, d3[2]);
                FemapModel.feViewRegenerate(0);
            }
        }

        private void PreWorkPlane()
        {
            for (int i = 0; i <= 2; i++)
            {
                FemapModel.set_Info_WorkplaneOrigin(i, FemapModel.get_Info_WorkplanePrevOrigin(i));
                FemapModel.set_Info_WorkplaneX(i, FemapModel.get_Info_WorkplanePrevX(i));
                FemapModel.set_Info_WorkplaneY(i, FemapModel.get_Info_WorkplanePrevY(i));
                FemapModel.set_Info_WorkplaneZ(i, FemapModel.get_Info_WorkplanePrevZ(i));
            }
            FemapModel.feViewRegenerate(0);
        }

        #endregion
    }
}