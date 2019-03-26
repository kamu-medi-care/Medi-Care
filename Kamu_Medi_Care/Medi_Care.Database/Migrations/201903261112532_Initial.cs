namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReceptionModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DrName = c.String(),
                        PName = c.String(),
                        FName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReceptionModels");
        }
    }
}
