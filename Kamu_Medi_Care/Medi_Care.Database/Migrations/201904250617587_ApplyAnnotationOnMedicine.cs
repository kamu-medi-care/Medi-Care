namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnMedicine : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppointMedicineModels", "PatientId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AppointMedicineModels", "PatientId", c => c.String());
        }
    }
}
