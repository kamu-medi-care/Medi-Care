namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Appointment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppointmentModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FName = c.String(),
                        Temperature = c.String(),
                        BloodPresure = c.String(),
                        PrevDate = c.String(),
                        Disease = c.String(),
                        Medicine = c.String(),
                        InDay = c.String(),
                        NextDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppointmentModels");
        }
    }
}
