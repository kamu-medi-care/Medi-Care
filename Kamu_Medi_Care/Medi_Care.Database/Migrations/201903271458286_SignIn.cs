namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SignIn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SignIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SignIns");
        }
    }
}
