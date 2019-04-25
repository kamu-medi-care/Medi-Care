namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientIdInReception : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReceptionModels", "PatientId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReceptionModels", "PatientId");
        }
    }
}
