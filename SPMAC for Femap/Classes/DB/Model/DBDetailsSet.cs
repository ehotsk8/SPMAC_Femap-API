using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using femap;

namespace SPMAC_for_Femap.Classes.DB.Model
{
    public class DBDetailsSet
    {
        [Key]
        [Required]
        public int DetailsSetId { get; set; }
        public string Name { get; set; }

        public virtual List<DBRod> Rod { get; set; }
        public virtual List<DBCoverRod> CoverRod { get; set; }
        public virtual List<DBSleeveCylinder> SleeveCylinder { get; set; }
        public virtual List<DBPiston> Piston { get; set; }
        public virtual List<DBFinger> Finger { get; set; }
        public virtual List<DBCrankshaft> Crankshaft { get; set; }
        public List<DBDetail_Created> DetailCreated { get; set; }

        public DBDetailsSet()
        {
            Rod = new List<DBRod>();
            CoverRod = new List<DBCoverRod>();
            Piston = new List<DBPiston>();
            Finger = new List<DBFinger>();
            Crankshaft = new List<DBCrankshaft>();
            DetailCreated = new List<DBDetail_Created>();
        }
        public class DBResults
        {
            [Key]
            [Required]
            public int ResultsId { get; set; }
            public string Title { get; set; }
            public double NodeId { get; set; }
            public double Stress { get; set; }
            public double Translate { get; set; }
            public virtual DBDetail_Created.DBAnalysis Analysis { get; set; }
        }
        public class DBDetail_Created
        {
            [Key]
            [Required]
            public int Detail_CreatedId { get; set; }
            public string DetailsList { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
            public virtual DBAnalysis Analysis { get; set; }

            public class DBAnalysis
            {
                [Key]
                [Required]
                public int AnalysisId { get; set; }
                [Required]
                public string Title { get; set; }

                public List<DBDetail_Created> DetailCreated { get; set; }

                public List<DBResults> Results { get; set; }
                public List<DBMaterials> Materials { get; set; }
                public List<DBConstraints> Contraints { get; set; }
                public List<DBLoads> Loads { get; set; }
                public List<DBPropertyAndMesh> PropertyAndMeshes { get; set; }

                public List<DBMaxMinStress> MaxMinStress { get; set; }
                public List<DBMaxMinTranslate> MaxMinTranslate { get; set; }

                public DBAnalysis()
                {
                    Results = new List<DBResults>();
                    Materials = new List<DBMaterials>();
                    Contraints = new List<DBConstraints>();
                    Loads = new List<DBLoads>();
                    PropertyAndMeshes = new List<DBPropertyAndMesh>();
                    DetailCreated = new List<DBDetail_Created>();
                    MaxMinStress = new List<DBMaxMinStress>();
                    MaxMinTranslate = new List<DBMaxMinTranslate>();
                }

                public class DBMaxMinStress
                {
                    [Key]
                    [Required]
                    public int SId { get; set; }
                    public int MaxId { get; set; }
                    public double Max { get; set; }
                    public int MinId { get; set; }
                    public double Min { get; set; }
                    public virtual DBAnalysis Analysis { get; set; }
                }

                public class DBMaxMinTranslate
                {
                    [Key]
                    [Required]
                    public int TId { get; set; }
                    public int MaxId { get; set; }
                    public double Max { get; set; }
                    public int MinId { get; set; }
                    public double Min { get; set; }
                    public virtual DBAnalysis Analysis { get; set; }
                }

                public class DBMaterials
                {
                    [Key]
                    [Required]
                    public int MaterialsId { get; set; }
                    public string Title { get; set; }
                    public double E { get; set; }
                    public double G { get; set; }
                    public double Nu { get; set; }
                    public virtual DBAnalysis Analysis { get; set; }
                }
                public class DBConstraints
                {
                    [Key]
                    [Required]
                    public int ConstraintsId { get; set; }
                    public string Title { get; set; }
                    public double SurfaceId { get; set; }
                    public bool TX { get; set; }
                    public bool TY { get; set; }
                    public bool TZ { get; set; }
                    public bool RX { get; set; }
                    public bool RY { get; set; }
                    public bool RZ { get; set; }
                    public virtual DBAnalysis Analysis { get; set; }
                }
                public class DBLoads
                {
                    [Key]
                    [Required]
                    public int LoadsId { get; set; }
                    public string Title { get; set; }
                    public double SurfaceId { get; set; }
                    public double Value { get; set; }
                    public zLoadType LoadType { get; set; }
                    public double X { get; set; }
                    public double Y { get; set; }
                    public double Z { get; set; }
                    public virtual DBAnalysis Analysis { get; set; }
                }
                public class DBPropertyAndMesh
                {
                    [Key]
                    [Required]
                    public int PropertyAndMeshId { get; set; }
                    public string Title { get; set; }
                    public int Property { get; set; }
                    public double MeshSize { get; set; }
                    public virtual DBAnalysis Analysis { get; set; }
                }
            }
        }

        public class DBRod
        {
            [Key]
            [Required]
            public int RodId { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
        }

        public class DBSleeveCylinder
        {
            [Key]
            [Required]
            public int RodId { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
        }

        public class DBCoverRod
        {
            [Key]
            [Required]
            public int CoverRodId { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
        }

        public class DBPiston
        {
            [Key]
            [Required]
            public int PistonId { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
        }

        public class DBFinger
        {
            [Key]
            [Required]
            public int FingerId { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
        }

        public class DBCrankshaft
        {
            [Key]
            [Required]
            public int CrankshaftId { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public virtual DBDetailsSet DetailsSet { get; set; }
        }
    }
}
