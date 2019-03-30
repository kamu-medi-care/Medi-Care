namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatitenIdInMedicineModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppointMedicineModels", "PatientId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppointMedicineModels", "PatientId");
        }
    }
}
