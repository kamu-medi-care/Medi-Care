namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointedMedicine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppointMedicineModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        InaDay = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppointMedicineModels");
        }
    }
}
