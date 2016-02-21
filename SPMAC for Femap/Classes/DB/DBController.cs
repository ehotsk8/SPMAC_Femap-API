using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using femap;
using SPMAC_for_Femap.Classes.DB.Model;

namespace SPMAC_for_Femap.Classes.DB
{
    class DBController
    {
        private readonly DBServerContext dbContext = new DBServerContext();

        public async Task AddSizesAsync(int DBDetailID, string DetailName)
        {
            using (DBServerContext db = new DBServerContext())
            {
                switch (DetailName)
                {
                    case "Поршень":
                        db.DETAILS.Find(DBDetailID).Piston = Sizes.Dictonary().Select(x => new DBDetailsSet.DBPiston { Key = x.Key, Value = x.Value }).ToList();
                        break;
                    case "Шатун":
                        db.DETAILS.Find(DBDetailID).Rod = Sizes.Dictonary().Select(x => new DBDetailsSet.DBRod { Key = x.Key, Value = x.Value }).ToList();
                        break;
                    case "Гильза цилиндра":
                        db.DETAILS.Find(DBDetailID).SleeveCylinder = Sizes.Dictonary()
                            .Select(x => new DBDetailsSet.DBSleeveCylinder { Key = x.Key, Value = x.Value }).ToList();
                        break;
                    case "Крышка шатуна":
                        db.DETAILS.Find(DBDetailID).CoverRod = Sizes.Dictonary().Select(x => new DBDetailsSet.DBCoverRod { Key = x.Key, Value = x.Value }).ToList();
                        break;
                    case "Поршневой палец":
                        db.DETAILS.Find(DBDetailID).Finger = Sizes.Dictonary().Select(x => new DBDetailsSet.DBFinger { Key = x.Key, Value = x.Value }).ToList();
                        break;
                    case "Коленчатый вал":
                        db.DETAILS.Find(DBDetailID).Crankshaft = Sizes.Dictonary().Select(x => new DBDetailsSet.DBCrankshaft { Key = x.Key, Value = x.Value }).ToList();
                        break;
                }
                db.DETAILS.Find(DBDetailID).DetailCreated = new List<DBDetailsSet.DBDetail_Created> { new DBDetailsSet.DBDetail_Created { DetailsList = DetailName } };
                await db.SaveChangesAsync();
            }
        }

        public async Task AddAnalysisAsync(string Title, int DBDetailID)
        {
            using (DBServerContext db = new DBServerContext())
            {
                db.Configuration.AutoDetectChangesEnabled = false;
                db.ANALYSIS.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis
                {
                    Title = Title,
                    Materials = db.MATERIALS.Where(w => w.Analysis == null).ToList(),
                    Loads = db.LOADS.Where(w => w.Analysis == null).ToList(),
                    Contraints = db.CONTRAINTS.Where(w => w.Analysis == null).ToList(),
                    Results = db.RESULTS.Where(w => w.Analysis == null).ToList(),
                    PropertyAndMeshes = db.PROPERTYANDMESHES.Where(w => w.Analysis == null).ToList(),
                    MaxMinStress = db.MAXMINSTRESS.Where(w => w.Analysis == null).ToList(),
                    MaxMinTranslate = db.MAXMINTRANSLATE.Where(w => w.Analysis == null).ToList()
                });
                db.Configuration.AutoDetectChangesEnabled = true;
                db.SaveChanges();
                db.CREATEDETAILS.Find(DBDetailID + 1).Analysis = db.ANALYSIS.Select(s => s).ToList()[db.ANALYSIS.Count() - 1];
                await db.SaveChangesAsync();
            }
        }

        public async Task AddMaterialAsync(string Title, double E, double Nu, double G)
        {
            using (DBServerContext db = new DBServerContext())
            {
                db.MATERIALS.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaterials { Title = Title, E = E, G = G, Nu = Nu });
                await db.SaveChangesAsync();
            }
        }

        public async Task AddLoadAsync(string Title, List<double> SurfaceId, double Value, zLoadType LoadType, double X, double Y, double Z)
        {
            using (DBServerContext db = new DBServerContext())
            {
                foreach (double t in SurfaceId)
                {
                    db.LOADS.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis.DBLoads
                    {
                        Title = Title,
                        SurfaceId = t,
                        Value = Value,
                        LoadType = LoadType,
                        X = X,
                        Y = Y,
                        Z = Z
                    });
                }
                await db.SaveChangesAsync();
            }
        }

        public async Task AddContraintAsync(string Title, List<double> SurfaceId, bool TX, bool TY, bool TZ, bool RX, bool RY, bool RZ)
        {
            using (DBServerContext db = new DBServerContext())
            {
                foreach (double t in SurfaceId)
                {
                    db.CONTRAINTS.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis.DBConstraints
                    {
                        Title = Title,
                        SurfaceId = t,
                        TX = TX,
                        TY = TY,
                        TZ = TZ,
                        RX = RX,
                        RY = RY,
                        RZ = RZ
                    });
                }
                await db.SaveChangesAsync();
            }
        }

        public async Task AddMeshAsync(string Title, double MeshSize, int PropertyId)
        {
            using (DBServerContext db = new DBServerContext())
            {
                db.PROPERTYANDMESHES.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis.DBPropertyAndMesh { Title = Title, MeshSize = MeshSize, Property = PropertyId });
                await db.SaveChangesAsync();
            }
        }

        public void AddResult(string Title, double Node, double Translate, double Stress, int index)
        {
            dbContext.Configuration.AutoDetectChangesEnabled = false;
            dbContext.RESULTS.Add(new DBDetailsSet.DBResults
            {
                Title = Title,
                NodeId = Node,
                Translate = Translate,
                Stress = Stress
            });
            dbContext.Configuration.AutoDetectChangesEnabled = true;
            if (index % 100 == 0)
                dbContext.SaveChanges();
        }

        public void AddResultMaxMin(int minIdStress, double minStress, int maxIdStress, double maxStress,
            int minIdTranslate, double minTranslate, int maxIdTranslate, double maxTranslate)
        {
            dbContext.MAXMINSTRESS.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinStress
            {
                MinId = minIdStress,
                Min = minStress,
                MaxId = maxIdStress,
                Max = maxStress
            });
            dbContext.MAXMINTRANSLATE.Add(new DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinTranslate
            {
                MinId = minIdTranslate,
                Min = minTranslate,
                MaxId = maxIdTranslate,
                Max = maxTranslate
            });
        }

        public void SaveResult()
        {
            dbContext.SaveChanges();
        }

        public async Task LogSQLServerAsync(int DBDetailID)
        {
            using (DBServerContext db = new DBServerContext())
            {
                DBDetailsSet detailsSet = new DBDetailsSet { Name = "Набор деталей: " + DBDetailID };
                db.DETAILS.Add(detailsSet);
                await db.SaveChangesAsync();
            }
        }

        public async void AddDetailsSet()
        {
            Context().DETAILS.Load();
            int id = Context().DETAILS.Count();
            Status.CurrentDetailsSetDirectory = Status.CurrentDirectory + "/FEMAP/DETAILS SET " + (id + 1);
            if (id > 0)
                await Task.Run(() => LogSQLServerAsync(id + 1));
            else await Task.Run(() => LogSQLServerAsync(1));
        }

        public DBServerContext Context()
        {
            return new DBServerContext();
        }
    }
}
