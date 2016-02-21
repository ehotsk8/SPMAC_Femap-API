using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPMAC_for_Femap.Forms;
using femap;
using SPMAC_for_Femap.Classes;

namespace SPMAC_for_Femap
{
    class MakeDetails
    {
        private femap.model FemapModel;

        public MakeDetails(femap.model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void Create_Crankshaft()
        {
            Status.createStatusStr = "Построение детали";
            FemapModel.feFileNew();
            FemapModel.set_Info_WorkplaneOrigin(2, 1);
            Point[] points = new Point[1000];
            Set feSet = FemapModel.feSet;
            for (int i = 0; i <= 20; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -156; points[0].z = 1;
            points[1].z = 26 / 2;
            object x = FemapModel.feCircleCenter((double)63.5 / 2, points[0].xyz, true);
            FemapModel.feBoundaryFromCurves(-1);
            FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[1].xyz);
            FemapModel.set_Info_WorkplaneOrigin(2, 26 / 2);
            points[2].z = 30 / 2;
            points[3].z = -26 / 2;
            FemapModel.feCircleCenter((double)72 / 2, points[0].xyz, true);
            FemapModel.feBoundaryFromCurves(-8);
            FemapModel.feSolidExtrude(0, 6, 0, 1, points[1].xyz, points[2].xyz);
            FemapModel.feGenerateReflect(zDataType.FT_SOLID, -2, points[0].xyz, points[3].xyz, 0, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(1, 3, 1);
            FemapModel.feSolidAdd(feSet.ID, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(4, 7, 1);
            FemapModel.feSolidChamfer(feSet.ID, 0.5);
            feSet = FemapModel.feSet;
            feSet.Add(14); feSet.Add(13); feSet.Add(20); feSet.Add(19);
            FemapModel.feSolidChamfer(feSet.ID, 2);
            FemapModel.set_Info_WorkplaneOrigin(2, 30 / 2);

            points[6].x = -156;
            points[7].x = -156; points[7].y = 30;
            points[8].x = -156 - 72 / 2;
            points[9].x = -156 - 86 / 2; points[9].y = 30;
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
            points[10].z = 30 / 2;
            points[11].z = 30 / 2 + 18;
            FemapModel.feSolidExtrude(0, 23, 0, 1, points[10].xyz, points[11].xyz);
            FemapModel.feGenerateReflect(zDataType.FT_SOLID, -4, points[0].xyz, points[3].xyz, 0, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(1, 10, 1);
            FemapModel.feSolidAdd(feSet.ID, true);

            points[12].z = 30 / 2 + 18;
            points[13].z = 30 / 2 + 18 + 2;
            FemapModel.set_Info_WorkplaneOrigin(2, 30 / 2 + 18);
            FemapModel.feCircleCenter((double)72 / 2, points[7].xyz, true);
            FemapModel.feBoundaryFromCurves(-69);
            FemapModel.feSolidExtrude(0, 36, 0, 1, points[12].xyz, points[13].xyz);
            FemapModel.feGenerateReflect(zDataType.FT_SOLID, -6, points[0].xyz, points[3].xyz, 0, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(1, 10, 1);
            FemapModel.feSolidAdd(feSet.ID, true);
            feSet.Add(73); feSet.Add(72); feSet.Add(79); feSet.Add(78);
            FemapModel.feSolidChamfer(feSet.ID, 2);

            FemapModel.set_Info_WorkplaneOrigin(2, 30 / 2 + 18 + 2);
            FemapModel.feCircleCenter((double)63.5 / 2, points[7].xyz, true);
            FemapModel.feBoundaryFromCurves(-90);
            points[14].z = 30 / 2 + 18 + 2;
            points[15].z = 30 / 2 + 18 + 2 + 26 / 2;
            FemapModel.feSolidExtrude(0, 49, 0, 1, points[14].xyz, points[15].xyz);
            FemapModel.feGenerateReflect(zDataType.FT_SOLID, -8, points[0].xyz, points[3].xyz, 0, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(1, 10, 1);
            FemapModel.feSolidAdd(feSet.ID, true);

            feSet.Add(96); feSet.Add(95); feSet.Add(101); feSet.Add(102);
            FemapModel.feSolidChamfer(feSet.ID, 0.5);

            points[16].x = -156; points[16].z = 1;
            points[17].x = -156; points[17].y = 156;

            FemapModel.feRotateBy(zDataType.FT_SOLID, -1, points[16].xyz, points[17].xyz, 180, 0);

            FemapModel.set_Info_WorkplaneOrigin(2, 0);

            FemapModel.feViewRegenerate(0);
            FemapModel.feFileSaveAs(false, "C:/FemapModels/Crankshaft.modfem");
            feSet = FemapModel.feSet;
            feSet.Add(1);
            FemapModel.feFileWriteStep("C:/FemapModels/Crankshaft.stp", feSet.ID);
            Status.createStatusStr = "Готово";
            FemapModel.feAppMessage(zMessageColor.FCM_WARNING, Status.createStatusStr);
        }

        public void Create_Cover_Rod()
        {
            Status.createStatusStr = "Построение детали";
            FemapModel.feFileNew();
            //  FemapModel.Pref_WorkplaneNotVisible = false;
            FemapModel.set_Info_WorkplaneOrigin(2, 1);
            Point[] points = new Point[1000];
            Set feSet = FemapModel.feSet;
            for (int i = 0; i <= 20; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -156; //center
            points[1].x = -156; points[1].y = 63.5 / 2;
            points[2].x = -156; points[2].y = (double)91 / 2;
            points[3].x = -156 - 5; points[3].y = (double)91 / 2;
            points[4].x = -156 - 5; points[4].y = 40;
            points[5].x = -156 - 36;
            points[6].x = -156 - 40; points[6].y = 10;// для join
            points[7].z = (double)26 / 2; // высоты
            points[8].z = 24 / 2; // высоты
            points[9].x = -156 - 10;
            points[10].x = -156 - 47.5;
            points[11].z = 19 / 2; // высоты
            points[12].x = -156 - 25 + 5; points[12].y = (double)91 / 2;
            points[13].x = -156 - 25 + 5; points[13].y = 40;
            points[14].z = ((double)15) / 2; // высоты

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

            FemapModel.set_Info_WorkplaneOrigin(2, 0);

            //_____________
            //righttrianglecut
            WorkPlane(false, 8, -156, 0, 1);
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = (double)6 / 2 + 1; points[0].y = (double)91 / 2;
            points[1].z = (double)26 / 2; points[1].y = (double)91 / 2;
            points[2].z = (double)26 / 2; points[2].y = (double)76 / 2;
            points[3].z = -(double)26 / 2 + 2; points[3].y = (double)76 / 2;
            points[4].z = -(double)6 / 2 + 1; points[4].y = (double)91 / 2;
            points[5].z = -(double)26 / 2 + 2; points[5].y = (double)91 / 2;
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

            //bolt
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = 1; points[0].y = (double)75 / 2;
            FemapModel.feCircleCenter((double)10 / 2, points[0].xyz, true);
            feSet = FemapModel.feSet;
            feSet.Add(73);
            FemapModel.feBoundaryFromCurves(feSet.ID);
            FemapModel.feSolidExtrude(2, 26, 2, 2, points[0].xyz, points[1].xyz);
            PreWorkPlane(); //workplane

            FemapModel.set_Info_WorkplaneOrigin(2, 1);
            //in
            for (int i = 0; i <= 20; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -156 - 25 + 5; ; points[0].y = (double)75 / 2;
            points[1].x = -156 - 25 + 5; ; points[1].y = (double)62 / 2;
            points[2].x = -156 - 24; ; points[2].y = (double)62 / 2;
            points[3].x = -156 - 10 - 63.5 / 2;
            points[4].x = -156 - 10 - 63.5 / 2; points[4].y = 10;
            points[5].x = -156 - 10 - 63.5 / 2 - 30;
            points[6].x = -156 - 10 - 63.5 / 2 - 30; points[6].y = (double)75 / 2;
            points[7].z = (double)26 / 2 - 3;
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

            //fask
            feSet = FemapModel.feSet;
            feSet.Add(18); feSet.Add(24); feSet.Add(79); feSet.Add(74); feSet.Add(109); feSet.Add(158);
            feSet.Add(156); feSet.Add(157); feSet.Add(78); feSet.Add(77);
            FemapModel.feSolidChamfer(feSet.ID, 0.5);

            feSet = FemapModel.feSet;
            feSet.Add(144); feSet.Add(141); feSet.Add(49); feSet.Add(53);
            FemapModel.feSolidFillet(feSet.ID, 4);

            feSet = FemapModel.feSet;
            feSet.Add(10); feSet.Add(37); feSet.Add(115); feSet.Add(114);
            FemapModel.feSolidFillet(feSet.ID, 4);

            FemapModel.feViewRegenerate(0);
            FemapModel.feFileSaveAs(false, "C:/FemapModels/CoverRod.modfem");
            FemapModel.feFileWriteStep("C:/FemapModels/CoverRod.stp", 1);
            Status.createStatusStr = "Готово";
            FemapModel.feAppMessage(zMessageColor.FCM_WARNING, Status.createStatusStr);
        }

        public void Create_Connecting_Rod()
        {
            Status.createStatusStr = "Построение детали";
            Status.boolStatus = (int)FemapModel.feFileNew();
            FemapModel.Pref_WorkplaneNotVisible = false;
            Status.progressValue = 5;
            Point[] points = new Point[1000];
            //circle1 right
            for (int i = 0; i <= 1; i++)
                points[i] = FemapModel.fePoint;
            points[1].z = Sizes.h1 / 2;
            Set feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.AddRange(1, 2, 1);
            Status.boolStatus = FemapModel.feCircleCenter(Sizes.d1 / 2, points[0].xyz, true);
            Status.boolStatus = FemapModel.feCircleCenter(Sizes.d2 / 2, points[0].xyz, true);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[1].xyz);
            Status.progressValue = 10;
            //centrertavr
            for (int i = 0; i <= 4; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -Sizes.l1; points[0].y = -Sizes.b1 / 2 - 0.5;
            points[1].x = -Sizes.l1; points[1].y = Sizes.b1 / 2 + 0.5;
            points[2].x = -Sizes.l3 + Sizes.l2; points[2].y = Sizes.b2 / 2 + 0.5;
            points[3].x = -Sizes.l3 + Sizes.l2; points[3].y = -Sizes.b2 / 2 - 0.5;
            points[4].z = -Sizes.h2 / 2 + 1;
            FemapModel.set_Info_WorkplaneOrigin(2, 1);
            for (int i = 0; i <= 2; i++)
                Status.boolStatus = FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[0].xyz, points[3].xyz, true);
            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.AddRange(15, 18, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(0, 8, 2, 1, points[0].xyz, points[4].xyz);
            Status.progressValue = 15;
            //leftuparc
            for (int i = 0; i <= 11; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -Sizes.l3;
            points[1].x = -Sizes.l3; points[1].y = Sizes.d3 / 2;
            points[2].x = -Sizes.l3; points[2].y = Sizes.b3 / 2;
            points[3].x = -Sizes.l3 + Sizes.l4; points[3].y = Sizes.b3 / 2;
            points[4].x = -Sizes.l3 + Sizes.l4; points[4].y = Sizes.r1 - 0.25;
            points[5].x = -Sizes.l3; points[5].y = -Sizes.d3 / 2;
            points[6].x = -Sizes.l3; points[6].y = -Sizes.b3 / 2;
            points[7].x = -Sizes.l3 + Sizes.l4; points[7].y = -Sizes.b3 / 2;
            points[8].x = -Sizes.l3 + Sizes.l4; points[8].y = -Sizes.r1 + 0.25;
            points[10].z = Sizes.h3 / 2;
            Status.boolStatus = FemapModel.feArcAngleCenterStart(-180, points[0].xyz, points[1].xyz, true);
            for (int i = 1; i <= 3; i++)
                Status.boolStatus = FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            for (int i = 5; i <= 7; i++)
                Status.boolStatus = FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            Status.boolStatus = FemapModel.feArcRadiusStartEnd(Sizes.r1, points[8].xyz, points[4].xyz, true);
            Status.boolStatus = (int)feSet.AddRange(31, 38, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(1, 15, 2, 1, points[0].xyz, points[10].xyz);
            Status.progressValue = 20;
            //add to surfase
            for (int i = 0; i <= 2; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -Sizes.l3 + Sizes.l2;
            points[1].x = -Sizes.l3 + Sizes.d3 / 2;
            points[2].x = -Sizes.l1;
            points[3].x = -Sizes.d1 / 2 - 0.5;
            Status.boolStatus = FemapModel.feSolidExtrude(1, 12, 0, 1, points[0].xyz, points[1].xyz);
            Status.boolStatus = FemapModel.feSolidExtrude(1, 10, 0, 1, points[2].xyz, points[3].xyz);
            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.AddRange(1, 3, 1);
            Status.boolStatus = (int)FemapModel.feSolidAdd(feSet.ID, true);

            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.AddRange(88, 89, 1);
            Status.boolStatus = (int)FemapModel.feSolidChamfer(feSet.ID, Sizes.r3);
            Status.boolStatus = (int)feSet.AddRange(94, 95, 1);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r2);
            Status.boolStatus = (int)feSet.AddRange(96, 97, 1);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r3);
            Status.progressValue = 25;
            //left arc center
            for (int i = 0; i <= 8; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -Sizes.l3;
            points[1].x = -Sizes.l3; points[1].y = Sizes.d3 / 2;
            points[2].x = -Sizes.l3; points[2].y = Sizes.b3 / 2;
            points[3].x = -Sizes.l3 + Sizes.l5; points[3].y = Sizes.b3 / 2;
            points[4].x = -Sizes.l3 + Sizes.l5; points[4].y = Sizes.d3 / 2;
            points[5].x = -Sizes.l3 + Sizes.l6; points[5].y = Sizes.d3 / 2;
            points[6].z = -(Sizes.h2 / 2) + 1;
            points[7].y = -1;
            for (int i = 1; i <= 4; i++)
                Status.boolStatus = FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.AddRange(114, 117, 1);
            Status.boolStatus = FemapModel.feGenerateReflect(zDataType.FT_CURVE, feSet.ID, points[0].xyz, points[7].xyz, 0, false);
            object[] point = new object[10];
            Status.boolStatus = (int)FemapModel.feCoordOnPoint(111, out point[0]);
            Status.boolStatus = (int)FemapModel.feCoordOnPoint(126, out point[1]);
            Status.boolStatus = (int)FemapModel.feCoordOnPoint(119, out point[2]);
            Status.boolStatus = (int)FemapModel.feCoordOnPoint(118, out point[3]);
            Status.boolStatus = FemapModel.feArcCenterStartEnd(points[0].xyz, point[1], point[3], true);
            Status.boolStatus = FemapModel.feArcCenterStartEnd(points[0].xyz, point[2], point[0], true);
            Status.boolStatus = (int)feSet.AddRange(114, 124, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(1, 39, 2, 1, points[0].xyz, points[6].xyz);
            Status.progressValue = 30;
            //60 radius leftarc
            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.Add(135);
            Status.boolStatus = (int)feSet.Add(124);
            FemapModel.feSolidFillet(feSet.ID, Sizes.r4);
            Status.boolStatus = (int)feSet.Add(82);
            Status.boolStatus = (int)feSet.Add(79);
            FemapModel.feSolidFillet(feSet.ID, Sizes.r5);
            Status.progressValue = 35;
            //rightouthole
            FemapModel.set_Info_WorkplaneOrigin(2, 0);
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = Sizes.d1 / 2 + 1; points[0].y = Sizes.b4 / 2;
            points[1].x = Sizes.l7; points[1].y = Sizes.b4 / 2;
            points[2].x = Sizes.l7; points[2].y = -Sizes.b4 / 2;
            points[3].x = Sizes.d1 / 2 + 1; points[3].y = -Sizes.b4 / 2;
            points[4].z = Sizes.h1 / 2;
            points[5].z = 0;
            for (int i = 0; i <= 2; i++)
                Status.boolStatus = FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[3].xyz, points[0].xyz, true);
            Status.boolStatus = (int)feSet.AddRange(184, 187, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(1, 60, 2, 1, points[5].xyz, points[4].xyz);
            Status.progressValue = 40;
            //centercutout
            FemapModel.set_Info_WorkplaneOrigin(2, 1);
            for (int i = 0; i <= 7; i++)
                points[i] = FemapModel.fePoint;
            points[0].x = -Sizes.l3 + Sizes.d3 / 2 + Sizes.l4 + Sizes.b2 / 2 - Sizes.b5 + 1; ; points[0].y = Sizes.b2 / 2 - Sizes.b5; points[0].z = Sizes.h2 / 2;
            points[1].x = -Sizes.l1; points[1].y = Sizes.b1 / 2 - Sizes.b5; points[1].z = Sizes.h2 / 2;
            points[2].z = Sizes.l8 / 2 + 1;
            points[3].x = -Sizes.l1; points[3].y = -Sizes.b1 / 2 + Sizes.b5; points[3].z = Sizes.h2 / 2;
            points[4].x = -Sizes.l3 + Sizes.d3 / 2 + Sizes.l4 + Sizes.b2 / 2 - Sizes.b5 + 1; ; points[4].y = -Sizes.b2 / 2 + Sizes.b5; points[4].z = Sizes.h2 / 2;
            points[5].z = 1;
            points[6].z = -Sizes.h2 / 2;
            points[7].z = -Sizes.l8 / 2 + 1;
            FemapModel.set_Info_WorkplaneOrigin(2, 7.5 + 1);
            Status.boolStatus = FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[3].xyz, points[4].xyz, true);
            Status.boolStatus = FemapModel.feArcAngleStartEnd(180, points[0].xyz, points[4].xyz, true);
            Status.boolStatus = FemapModel.feArcAngleStartEnd(180, points[3].xyz, points[1].xyz, true);
            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.AddRange(198, 201, 1);
            Status.boolStatus = FemapModel.feGenerateReflect(zDataType.FT_CURVE, feSet.ID, points[5].xyz, points[6].xyz, 0, true);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 64, 2, 1, points[0].xyz, points[2].xyz);
            Status.boolStatus = (int)feSet.AddRange(202, 205, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 71, 2, 1, points[6].xyz, points[7].xyz);
            FemapModel.set_Info_WorkplaneOrigin(2, 0);
            Status.progressValue = 45;
            //righttrianglecut
            WorkPlane(false, 39, -156, 0, 1);
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = Sizes.l9 / 2 + 1; points[0].y = Sizes.b3 / 2;
            points[1].z = Sizes.h3 / 2; points[1].y = Sizes.b3 / 2;
            points[2].z = Sizes.h3 / 2; points[2].y = Sizes.b6 / 2;
            points[3].z = -Sizes.h3 / 2 + 2; points[3].y = Sizes.b6 / 2;
            points[4].z = -Sizes.l9 / 2 + 1; points[4].y = Sizes.b3 / 2;
            points[5].z = -Sizes.h3 / 2 + 2; points[5].y = Sizes.b3 / 2;
            Status.boolStatus = FemapModel.feLinePoints(true, points[0].xyz, points[1].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[1].xyz, points[2].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[2].xyz, points[0].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[3].xyz, points[4].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[4].xyz, points[5].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[5].xyz, points[3].xyz, true);
            points[6].z = Sizes.l9 / 2 + 1; points[6].y = -Sizes.b3 / 2;
            points[7].z = Sizes.h3 / 2; points[7].y = -Sizes.b3 / 2;
            points[8].z = Sizes.h3 / 2; points[8].y = -Sizes.b6 / 2;
            points[9].z = -Sizes.h3 / 2 + 2; points[9].y = -Sizes.b6 / 2;
            points[10].z = -Sizes.l9 / 2 + 1; points[10].y = -Sizes.b3 / 2;
            points[11].z = -Sizes.h3 / 2 + 2; points[11].y = -Sizes.b3 / 2;
            Status.boolStatus = FemapModel.feLinePoints(true, points[6].xyz, points[7].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[7].xyz, points[8].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[8].xyz, points[6].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[9].xyz, points[10].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[10].xyz, points[11].xyz, true);
            Status.boolStatus = FemapModel.feLinePoints(true, points[11].xyz, points[9].xyz, true);
            Status.boolStatus = (int)feSet.AddRange(245, 247, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 78, 2, 1, points[6].xyz, points[7].xyz);
            Status.boolStatus = (int)feSet.AddRange(242, 244, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 80, 2, 1, points[6].xyz, points[7].xyz);
            Status.boolStatus = (int)feSet.AddRange(251, 253, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 82, 2, 1, points[6].xyz, points[7].xyz);
            Status.boolStatus = (int)feSet.AddRange(248, 250, 1);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 84, 2, 1, points[6].xyz, points[7].xyz);
            Status.progressValue = 50;
            //boltcut
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = 1; points[0].y = Sizes.b7 / 2;
            points[1].z = 1; points[1].y = -Sizes.b7 / 2;
            Status.boolStatus = FemapModel.feCircleCenter(Sizes.d4 / 2, points[0].xyz, true);
            Status.boolStatus = FemapModel.feCircleCenter(Sizes.d4 / 2, points[1].xyz, true);
            feSet = FemapModel.feSet;
            Status.boolStatus = (int)feSet.Add(278);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 86, 2, 1, points[6].xyz, points[7].xyz);
            Status.boolStatus = (int)feSet.Add(279);
            Status.boolStatus = (int)FemapModel.feBoundaryFromCurves(feSet.ID);
            Status.boolStatus = FemapModel.feSolidExtrude(2, 89, 2, 1, points[6].xyz, points[7].xyz);
            PreWorkPlane();
            Status.progressValue = 55;
            //faskee
            feSet = FemapModel.feSet;
            feSet.Add(10); feSet.Add(9); feSet.Add(13); feSet.Add(14); feSet.Add(54); feSet.Add(62);
            feSet.Add(286); feSet.Add(287); feSet.Add(289); feSet.Add(288); feSet.Add(283); feSet.Add(282);
            feSet.Add(280); feSet.Add(281);//find
            Status.boolStatus = (int)FemapModel.feSolidChamfer(feSet.ID, Sizes.r6);
            Status.progressValue = 60;
            feSet = FemapModel.feSet;
            feSet.AddRange(238, 241, 1);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r7);
            feSet.AddRange(220, 223, 1);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r7);
            Status.progressValue = 65;
            feSet = FemapModel.feSet;
            feSet.Add(81); feSet.Add(85);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r8);
            Status.progressValue = 70;
            feSet = FemapModel.feSet;
            feSet.Add(80); feSet.Add(84);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r9);
            Status.progressValue = 75;
            feSet = FemapModel.feSet;
            feSet.Add(213); feSet.Add(212); feSet.Add(207); feSet.Add(208);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r10);
           
            feSet = FemapModel.feSet;
            feSet.Add(230); feSet.Add(231); feSet.Add(225); feSet.Add(226);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r10);
            Status.progressValue = 80;
            feSet = FemapModel.feSet;
            feSet.Add(188); feSet.Add(189);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r12);

            feSet = FemapModel.feSet;
            feSet.Add(149); feSet.Add(152);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r13);
            Status.progressValue = 85;
            feSet = FemapModel.feSet;
            feSet.Add(137); feSet.Add(138); feSet.Add(140); feSet.Add(141);
            feSet.Add(147); feSet.Add(146); feSet.Add(144); feSet.Add(143);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r11);
            Status.progressValue = 90;
            feSet = FemapModel.feSet;
            feSet.Add(136); feSet.Add(142); feSet.Add(139); feSet.Add(145);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r13);

            feSet.Add(99); feSet.Add(101); feSet.Add(541); feSet.Add(543);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r13);
            Status.progressValue = 98;
            feSet = FemapModel.feSet;
            feSet.AddRange(170, 173, 1);
            Status.boolStatus = (int)FemapModel.feSolidFillet(feSet.ID, Sizes.r10);
            FemapModel.Pref_WorkplaneNotVisible = true;
            Status.boolStatus = (int)FemapModel.feViewRegenerate(0);
            Status.boolStatus = (int)FemapModel.feFileSaveAs(false, "C:/FemapModels/Rod.modfem");
            Status.boolStatus = (int)FemapModel.feFileWriteStep("C:/FemapModels/Rod.stp", 1);
            Status.progressValue = 100;
            Status.createStatusStr = "Готово";
            Status.progressValue = 0;
        }

        //Пoршень
        public void Create_Piston()
        {
            Status.createStatusStr = "Построение детали";
            FemapModel.feFileNew();

            FemapModel.Pref_WorkplaneNotVisible = false;

            Point[] points = new Point[100];
            //circle1 right
            for (int i = 0; i <= 50; i++)
                points[i] = FemapModel.fePoint;
            points[1].x = 81.2 / 2;
            points[2].x = 81.2 / 2; points[2].y = -12.8;
            points[3].x = 81.2 / 2 - 4.1; points[3].y = -12.8;
            points[4].x = 81.2 / 2 - 4.1; points[4].y = -12.8 - 2.4;
            points[5].x = 81.2 / 2; points[5].y = -12.8 - 2.4;
            points[6].x = 81.2 / 2; points[6].y = -18.8;
            points[7].x = 81.2 / 2 - 4.1; points[7].y = -18.8;
            points[8].x = 81.2 / 2 - 4.1; points[8].y = -18.8 - 2.4;
            points[9].x = 81.2 / 2; points[9].y = -18.8 - 2.4;
            points[10].x = 81.2 / 2; points[10].y = -18.8 - 2.4 - 1.2;
            points[11].x = 81.2 / 2; points[11].y = -24;
            points[12].x = 81.2 / 2 - 4.1; points[12].y = -24;
            points[13].x = 81.2 / 2 - 4.1; points[13].y = -24 - 5;
            points[14].x = 81.2 / 2; points[14].y = -24 - 5;
            points[15].x = 81.2 / 2; points[15].y = -24 - 5 - 1.5;
            points[16].x = 81.2 / 2; points[16].y = -92;
            points[17].x = 78 / 2; points[17].y = -92;
            points[18].x = 78 / 2; points[18].y = -92 + 5;
            points[19].x = 76.8 / 2; points[19].y = -92 + 5;
            points[20].x = 76.8 / 2; points[20].y = -34;
            points[21].x = 64 / 2; points[21].y = -34;
            points[22].x = 64 / 2; points[22].y = -23;
            points[23].x = 62 / 2; points[23].y = -23;
            points[24].x = 62 / 2; points[24].y = -8;
            points[25].y = -8;
            points[26].x = 81.2 / 2 - 33 / 2;
            for (int i = 0; i <= 15; i++)
                FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            object[] point = new object[10];
            FemapModel.feCoordOnPoint(20, out point[0]);
            FemapModel.feCoordOnPoint(18, out point[1]);
            FemapModel.feLineAtAngle(330, 10, point[0], point[1], true);
            FemapModel.feCurveJoin(17, 9, points[8].xyz, true, true);
            Set feSet = FemapModel.feSet;
            feSet.Add(10);
            FemapModel.feDelete(zDataType.FT_CURVE, feSet.ID);
            feSet.Add(19);
            FemapModel.feDelete(zDataType.FT_POINT, feSet.ID);
            FemapModel.feCoordOnPoint(30, out point[2]);
            FemapModel.feCoordOnPoint(28, out point[3]);
            FemapModel.feLineAtAngle(340, 15, point[2], point[3], true);
            FemapModel.feCurveJoin(18, 14, points[12].xyz, true, true);
            feSet.Add(15);
            FemapModel.feDelete(zDataType.FT_CURVE, feSet.ID);
            feSet.Add(29);
            FemapModel.feDelete(zDataType.FT_POINT, feSet.ID);
            for (int i = 16; i <= 24; i++)
                FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            FemapModel.feLinePoints(true, points[25].xyz, points[0].xyz, true);
            feSet.AddRange(0, 35, 1);
            FemapModel.feBoundaryFromCurves(feSet.ID);
            FemapModel.feAppMessage(zMessageColor.FCM_ERROR, FemapModel.feSolidRevolve(0, 1, 0, 2, points[0].xyz, points[25].xyz, points[1].xyz));

            FemapModel.feLineHorzVert(true, points[0].xyz, 15, true);

            WorkPlane(false, 101, 33 / 2, -51, 0);

            points = new Point[100];
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].y = -51;
            points[1].z = 15; points[1].y = -51;
            points[3].x = 1;
            points[4].z = 11; points[4].y = -51;
            points[5].x = 81.2 / 2 - 33 / 2 - 10;
            points[6].x = 150;
            points[7].x = -150 - 33 / 2;
            points[8].x = -33 / 2;
            points[9].z = 16; points[9].y = -51;
            points[10].x = 10;
            points[2].Put(2);
            FemapModel.feCircleRadius(points[0].xyz, points[1].xyz, true);
            feSet = FemapModel.feSet;
            feSet.Add(104);
            FemapModel.feGenerateReflect(zDataType.FT_CURVE, feSet.ID, points[2].xyz, points[3].xyz, 0, true);
            // FemapModel.feBoundaryFromCurves(feSet.ID);
            // FemapModel.feSolidExtrude(1, 40, 1, 0, points[2].xyz, points[5].xyz);

            FemapModel.feCurveProjectOntoSurfaces(false, points[6].xyz, -20, -104, true);
            FemapModel.feCurveProjectOntoSurfaces(false, points[7].xyz, -12, -105, true);
            FemapModel.feSolidSweep(-12, -103);
            FemapModel.feSolidSweep(-40, -103);
            feSet = FemapModel.feSet;
            feSet.AddRange(1, 3, 1);
            FemapModel.feSolidAdd(feSet.ID, true);
            //FemapModel.feSolidExtrude(1, 50, 0, 0, points[2].xyz, points[5].xyz);
            //FemapModel.feBoundaryFromCurves(-105);
            //FemapModel.feSolidExtrude(2, 51, 2, 0, points[2].xyz, points[6].xyz);

            FemapModel.feCircleRadius(points[0].xyz, points[4].xyz, true);
            FemapModel.feCircleRadius(points[0].xyz, points[9].xyz, true);
            FemapModel.feBoundaryFromCurves(-123);
            FemapModel.feSolidExtrude(2, 50, 1, 1, points[0].xyz, points[8].xyz);
            FemapModel.feBoundaryFromCurves(-122);
            FemapModel.feSolidExtrude(2, 53, 2, 2, points[2].xyz, points[6].xyz);

            WorkPlane(false, 101, 81.2 / 2, -51, 0);
            points = new Point[100];
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = 30; points[0].y = 15 - 51;
            points[1].z = -30; points[1].y = 15 - 51;
            points[2].z = -30; points[2].y = 15 - 35 - 51;
            points[3].z = 30; points[3].y = 15 - 35 - 51;
            points[4].x = 77.6 / 2;
            for (int i = 0; i <= 2; i++)
                FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            FemapModel.feLinePoints(true, points[0].xyz, points[3].xyz, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(140, 143, 1);
            FemapModel.feBoundaryFromCurves(feSet.ID);
            FemapModel.feSolidExtrude(2, 58, 0, 1, points[0].xyz, points[4].xyz);


            WorkPlane(false, 102, -81.2 / 2, -51, 0);
            points = new Point[100];
            for (int i = 0; i <= 10; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = 30; points[0].y = 15 - 51;
            points[1].z = -30; points[1].y = 15 - 51;
            points[2].z = -30; points[2].y = 15 - 35 - 51;
            points[3].z = 30; points[3].y = 15 - 35 - 51;
            points[4].x = -77.6 / 2;
            for (int i = 0; i <= 2; i++)
                FemapModel.feLinePoints(true, points[i].xyz, points[i + 1].xyz, true);
            FemapModel.feLinePoints(true, points[0].xyz, points[3].xyz, true);
            feSet = FemapModel.feSet;
            feSet.AddRange(152, 155, 1);
            FemapModel.feBoundaryFromCurves(feSet.ID);
            FemapModel.feSolidExtrude(2, 62, 0, 1, points[0].xyz, points[4].xyz);


            WorkPlane(false, 101, 33 / 2, 0, 0);
            //zhest
            object[] pointArcXYZ = new object[20];
            FemapModel.feCoordOnPoint(37, out pointArcXYZ[0]);
            FemapModel.feCoordOnPoint(38, out pointArcXYZ[1]);
            for (int i = 0; i <= 50; i++)
                points[i] = FemapModel.fePoint;
            points[0].z = -17; points[0].y = -8;
            points[1].z = 17; points[1].y = -8;
            FemapModel.feLinePoints(true, points[0].xyz, pointArcXYZ[0], true);
            FemapModel.feLinePoints(true, points[1].xyz, pointArcXYZ[1], true);
            points[2].z = -17 + 5; points[2].y = -8;
            points[3].z = 17 - 5; points[3].y = -8;
            FemapModel.feLinePoints(true, points[0].xyz, points[2].xyz, true);
            FemapModel.feLinePoints(true, points[1].xyz, points[3].xyz, true);
            FemapModel.feCoordOnPoint(47, out pointArcXYZ[2]);
            FemapModel.feCoordOnPoint(48, out pointArcXYZ[3]);
            FemapModel.feLinePoints(true, pointArcXYZ[2], points[2].xyz, true);
            FemapModel.feLinePoints(true, pointArcXYZ[3], points[3].xyz, true);
            FemapModel.feLinePoints(true, pointArcXYZ[0], pointArcXYZ[2], true);
            FemapModel.feLinePoints(true, pointArcXYZ[1], pointArcXYZ[3], true);
            points[5].x = -1;
            points[6].z = -1;

            feSet = FemapModel.feSet;
            feSet.AddRange(164, 171, 1);
            FemapModel.feGenerateReflect(zDataType.FT_CURVE, feSet.ID, points[4].xyz, points[5].xyz, 0, true);
            feSet = FemapModel.feSet;
            feSet.Add(169); feSet.Add(165); feSet.Add(167); feSet.Add(171);
            FemapModel.feBoundaryFromCurves(feSet.ID);
            points[7].x = 62 / 2;
            FemapModel.feSolidExtrude(0, 66, 0, 1, points[4].xyz, points[7].xyz);

            feSet = FemapModel.feSet;
            feSet.Add(4);
            FemapModel.feGenerateReflect(zDataType.FT_SOLID, feSet.ID, points[4].xyz, points[5].xyz, 0, true);
            feSet.AddRange(4, 5, 1);
            FemapModel.feGenerateReflect(zDataType.FT_SOLID, feSet.ID, points[4].xyz, points[6].xyz, 0, true);

            feSet.AddRange(1, 10, 1);
            FemapModel.feSolidAdd(feSet.ID, true);

            //fask
            //feSet = FemapModel.feSet;
            //feSet.Add(102); feSet.Add(101);
            //feSet.Add(146); feSet.Add(149); feSet.Add(158); feSet.Add(161);
            //FemapModel.feSolidChamfer(feSet.ID, 0.5);

            FemapModel.Pref_WorkplaneNotVisible = true;
            PreWorkPlane();
            FemapModel.feViewRegenerate(0);
            FemapModel.feFileSaveAs(false, "C:/FemapModels/Piston.modfem");
            FemapModel.feFileWriteStep("C:/FemapModels/Piston.stp", 1);
            Status.createStatusStr = "Готово";
        }

        public void Create_PistonFinger()
        {
            Status.createStatusStr = "Построение детали";
            FemapModel.feFileNew();
            FemapModel.Pref_WorkplaneNotVisible = false;
            Set feSet = FemapModel.feSet;
            Point[] points = new Point[100];
            for (int i = 0; i <= 3; i++)
                points[i] = FemapModel.fePoint;
            points[1].z = 77.6 / 2;
            FemapModel.feCircleCenter(11, points[0].xyz, true);
            FemapModel.feCircleCenter(8, points[0].xyz, true);
            feSet = FemapModel.feSet;
            feSet.Add(1); feSet.Add(2);
            FemapModel.feBoundaryFromCurves(feSet.ID);
            FemapModel.feSolidExtrude(0, 1, 2, 1, points[0].xyz, points[1].xyz);
            FemapModel.Pref_WorkplaneNotVisible = true;
            FemapModel.feViewRegenerate(0);
            FemapModel.feFileSaveAs(false, "C:/FemapModels/Finger.modfem");
            feSet = FemapModel.feSet;

            feSet.Add(8); feSet.Add(7); feSet.Add(12); feSet.Add(11);
            feSet.Add(9); feSet.Add(10); feSet.Add(14); feSet.Add(13);
            FemapModel.feSolidChamfer(feSet.ID, 0.5);

            feSet = FemapModel.feSet;
            feSet.AddRange(0, 10, 1);
            FemapModel.feFileWriteStep("C:/FemapModels/Finger.stp", feSet.ID);
            Status.createStatusStr = "Готово";
        }

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
    }
}