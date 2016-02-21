using System.Data.Entity;
using SPMAC_for_Femap.Classes.DB.Model;

namespace SPMAC_for_Femap.Classes.DB
{
    class DBServerContext : DbContext
    {
        public DBServerContext()
            : base("DBConnection") { }

        public DbSet<DBDetailsSet> DETAILS { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created> CREATEDETAILS { get; set; }
        public DbSet<DBDetailsSet.DBRod> ROD { get; set; }
        public DbSet<DBDetailsSet.DBCoverRod> COVERROD { get; set; }
        public DbSet<DBDetailsSet.DBPiston> PISTON { get; set; }
        public DbSet<DBDetailsSet.DBFinger> FINGER { get; set; }
        public DbSet<DBDetailsSet.DBCrankshaft> CRANKSHAFT { get; set; }
        public DbSet<DBDetailsSet.DBSleeveCylinder> SLEEVECYLINDER { get; set; }

        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis> ANALYSIS { get; set; }
        public DbSet<DBDetailsSet.DBResults> RESULTS { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis.DBConstraints> CONTRAINTS { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaterials> MATERIALS { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis.DBLoads> LOADS { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis.DBPropertyAndMesh> PROPERTYANDMESHES { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinStress> MAXMINSTRESS { get; set; }
        public DbSet<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinTranslate> MAXMINTRANSLATE { get; set; }
    }
}
