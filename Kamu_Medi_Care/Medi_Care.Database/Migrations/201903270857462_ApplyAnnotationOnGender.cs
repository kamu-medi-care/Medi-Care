namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnGender : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReceptionModels", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReceptionModels", "Gender", c => c.Int(nullable: false));
        }
    }
}
