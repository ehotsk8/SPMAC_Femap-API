using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SPMAC_for_Femap.Classes.DB.Model;
using Word = Microsoft.Office.Interop.Word;

namespace SPMAC_for_Femap.Classes
{
    class OutputDataToWord
    {
        public async Task CreateWordAsync(int detailId, string detailName, int detailSetId,
            dynamic detail,
            List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaterials> materials,
            List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBLoads> loads,
            List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBConstraints> constraints,
            List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinStress> stresses,
            List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinTranslate> translates,
            List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBPropertyAndMesh> propertyAndMeshes,
            List<DBDetailsSet.DBResults> results)
        {
            var word = new Word.Application();
            var document = word.Documents.Add();
            word.Visible = true;

            var heading = document.Content.Paragraphs.Add(Missing.Value);
            heading.Range.Text = String.Format("ID: {0};\nИмя детали: {1};\nНабор деталей: {2};", detailId, detailName, detailSetId);

            heading.Range.InsertParagraphAfter();
            heading.Range.Text = "\nМАТЕРИАЛЫ";
            heading.Range.InsertParagraphAfter();
            var tableMaterials = document.Content.Tables.Add(heading.Range, materials.Count + 1, 5);
            tableMaterials.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableMaterials.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableMaterials.Cell(1, 1).Range.Text = "ID";
            tableMaterials.Cell(1, 2).Range.Text = "Заголовок";
            tableMaterials.Cell(1, 3).Range.Text = "E";
            tableMaterials.Cell(1, 4).Range.Text = "G";
            tableMaterials.Cell(1, 5).Range.Text = "Nu";
            for (var i = 0; i < materials.Count; i++)
            {
                tableMaterials.Cell(i + 2, 1).Range.Text = materials[i].MaterialsId.ToString();
                tableMaterials.Cell(i + 2, 2).Range.Text = materials[i].Title.ToString();
                tableMaterials.Cell(i + 2, 3).Range.Text = materials[i].E.ToString();
                tableMaterials.Cell(i + 2, 4).Range.Text = materials[i].G.ToString();
                tableMaterials.Cell(i + 2, 5).Range.Text = materials[i].Nu.ToString();
            }

            heading.Range.Text = "\nНАГРУЗКИ";
            heading.Range.InsertParagraphAfter();
            var tableLoads = document.Content.Tables.Add(heading.Range, loads.Count + 1, 8);
            tableLoads.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableLoads.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableLoads.Cell(1, 1).Range.Text = "ID";
            tableLoads.Cell(1, 2).Range.Text = "Заголовок";
            tableLoads.Cell(1, 3).Range.Text = "ID плоскости";
            tableLoads.Cell(1, 4).Range.Text = "Значение";
            tableLoads.Cell(1, 5).Range.Text = "Тип нагрузки";
            tableLoads.Cell(1, 6).Range.Text = "X";
            tableLoads.Cell(1, 7).Range.Text = "Y";
            tableLoads.Cell(1, 8).Range.Text = "Z";
            for (var i = 0; i < loads.Count; i++)
            {
                tableLoads.Cell(i + 2, 1).Range.Text = loads[i].LoadsId.ToString();
                tableLoads.Cell(i + 2, 2).Range.Text = loads[i].Title.ToString();
                tableLoads.Cell(i + 2, 3).Range.Text = loads[i].SurfaceId.ToString();
                tableLoads.Cell(i + 2, 4).Range.Text = loads[i].Value.ToString();
                tableLoads.Cell(i + 2, 5).Range.Text = loads[i].LoadType.ToString();
                tableLoads.Cell(i + 2, 6).Range.Text = loads[i].X.ToString();
                tableLoads.Cell(i + 2, 7).Range.Text = loads[i].Y.ToString();
                tableLoads.Cell(i + 2, 8).Range.Text = loads[i].Z.ToString();
            }

            heading.Range.Text = "\nГРАНИЧНЫЕ УСЛОВИЯ";
            heading.Range.InsertParagraphAfter();
            var tableConstraints = document.Content.Tables.Add(heading.Range, constraints.Count + 1, 9);
            tableConstraints.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableConstraints.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableConstraints.Cell(1, 1).Range.Text = "ID";
            tableConstraints.Cell(1, 2).Range.Text = "Заголовок";
            tableConstraints.Cell(1, 3).Range.Text = "ID плоскости";
            tableConstraints.Cell(1, 4).Range.Text = "TX";
            tableConstraints.Cell(1, 5).Range.Text = "TY";
            tableConstraints.Cell(1, 6).Range.Text = "TZ";
            tableConstraints.Cell(1, 7).Range.Text = "RX";
            tableConstraints.Cell(1, 8).Range.Text = "RY";
            tableConstraints.Cell(1, 9).Range.Text = "RZ";
            for (var i = 0; i < constraints.Count; i++)
            {
                tableConstraints.Cell(i + 2, 1).Range.Text = constraints[i].ConstraintsId.ToString();
                tableConstraints.Cell(i + 2, 2).Range.Text = constraints[i].Title.ToString();
                tableConstraints.Cell(i + 2, 3).Range.Text = constraints[i].SurfaceId.ToString();
                tableConstraints.Cell(i + 2, 4).Range.Text = constraints[i].TX.ToString();
                tableConstraints.Cell(i + 2, 5).Range.Text = constraints[i].TY.ToString();
                tableConstraints.Cell(i + 2, 6).Range.Text = constraints[i].TZ.ToString();
                tableConstraints.Cell(i + 2, 7).Range.Text = constraints[i].RX.ToString();
                tableConstraints.Cell(i + 2, 8).Range.Text = constraints[i].RY.ToString();
                tableConstraints.Cell(i + 2, 9).Range.Text = constraints[i].RZ.ToString();
            }

            heading.Range.Text = "\nСВОЙСТВА";
            heading.Range.InsertParagraphAfter();
            var tablePropertyAndMeshes = document.Content.Tables.Add(heading.Range, propertyAndMeshes.Count + 1, 3);
            tablePropertyAndMeshes.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tablePropertyAndMeshes.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tablePropertyAndMeshes.Cell(1, 1).Range.Text = "ID";
            tablePropertyAndMeshes.Cell(1, 2).Range.Text = "Заголовок";
            tablePropertyAndMeshes.Cell(1, 3).Range.Text = "Размер сетки";
            for (var i = 0; i < propertyAndMeshes.Count; i++)
            {
                tablePropertyAndMeshes.Cell(i + 2, 1).Range.Text = propertyAndMeshes[i].PropertyAndMeshId.ToString();
                tablePropertyAndMeshes.Cell(i + 2, 2).Range.Text = propertyAndMeshes[i].Title.ToString();
                tablePropertyAndMeshes.Cell(i + 2, 3).Range.Text = propertyAndMeshes[i].MeshSize.ToString();
            }

            heading.Range.Text = "\nМАКСИМАЛЬНЫЕ И МИНИМАЛЬНЫЕ НАПРЯЖЕНИЯ";
            heading.Range.InsertParagraphAfter();
            var tableTranslates = document.Content.Tables.Add(heading.Range, translates.Count + 1, 4);
            tableTranslates.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableTranslates.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableTranslates.Cell(1, 1).Range.Text = "Max ID";
            tableTranslates.Cell(1, 2).Range.Text = "Значение";
            tableTranslates.Cell(1, 3).Range.Text = "Min ID";
            tableTranslates.Cell(1, 4).Range.Text = "Значение";
            for (var i = 0; i < translates.Count; i++)
            {
                tableTranslates.Cell(i + 2, 1).Range.Text = translates[i].MaxId.ToString();
                tableTranslates.Cell(i + 2, 2).Range.Text = translates[i].Max.ToString();
                tableTranslates.Cell(i + 2, 3).Range.Text = translates[i].MinId.ToString();
                tableTranslates.Cell(i + 2, 4).Range.Text = translates[i].Min.ToString();
            }

            heading.Range.Text = "\nМАКСИМАЛЬНЫЕ И МИНИМАЛЬНЫЕ ПЕРЕМЕЩЕНИЯ";
            heading.Range.InsertParagraphAfter();
            var tableStresses = document.Content.Tables.Add(heading.Range, stresses.Count + 1, 4);
            tableStresses.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableStresses.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableStresses.Cell(1, 1).Range.Text = "Max ID";
            tableStresses.Cell(1, 2).Range.Text = "Значение";
            tableStresses.Cell(1, 3).Range.Text = "Min ID";
            tableStresses.Cell(1, 4).Range.Text = "Значение";
            for (var i = 0; i < stresses.Count; i++)
            {
                tableStresses.Cell(i + 2, 1).Range.Text = stresses[i].MaxId.ToString();
                tableStresses.Cell(i + 2, 2).Range.Text = stresses[i].Max.ToString();
                tableStresses.Cell(i + 2, 3).Range.Text = stresses[i].MinId.ToString();
                tableStresses.Cell(i + 2, 4).Range.Text = stresses[i].Min.ToString();
            }

            heading.Range.Text = "\nРАЗМЕРЫ";
            heading.Range.InsertParagraphAfter();
            var tableSizes = document.Content.Tables.Add(heading.Range, detail.Count + 1, 2);
            tableSizes.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableSizes.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tableSizes.Cell(1, 1).Range.Text = "Название";
            tableSizes.Cell(1, 2).Range.Text = "Значение";
            for (var i = 0; i < detail.Count; i++)
            {
                tableSizes.Cell(i + 2, 1).Range.Text = detail[i].Key.ToString();
                tableSizes.Cell(i + 2, 2).Range.Text = detail[i].Value.ToString();
            }

            heading.Range.Text = "\nРЕЗУЛЬТАТЫ";
            heading.Range.InsertParagraphAfter();
            var table = document.Content.Tables.Add(heading.Range, results.Count + 1, 3);
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Cell(1, 1).Range.Text = "ID";
            table.Cell(1, 2).Range.Text = "Напряжение";
            table.Cell(1, 3).Range.Text = "Перемещение";
            for (var i = 0; i < results.Count; i++)
            {
                table.Cell(i + 2, 1).Range.Text = results[i].NodeId.ToString();
                table.Cell(i + 2, 2).Range.Text = results[i].Stress.ToString();
                table.Cell(i + 2, 3).Range.Text = results[i].Translate.ToString();
            }
        }
    }
}
