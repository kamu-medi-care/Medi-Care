namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnRepection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReceptionModels", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.ReceptionModels", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.ReceptionModels", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.ReceptionModels", "PhoneNo", c => c.String());
            AddColumn("dbo.ReceptionModels", "Address", c => c.String());
            AddColumn("dbo.ReceptionModels", "Fee", c => c.Double(nullable: false));
            AddColumn("dbo.ReceptionModels", "Temperature", c => c.String());
            AddColumn("dbo.ReceptionModels", "BloodPresure", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReceptionModels", "BloodPresure");
            DropColumn("dbo.ReceptionModels", "Temperature");
            DropColumn("dbo.ReceptionModels", "Fee");
            DropColumn("dbo.ReceptionModels", "Address");
            DropColumn("dbo.ReceptionModels", "PhoneNo");
            DropColumn("dbo.ReceptionModels", "Gender");
            DropColumn("dbo.ReceptionModels", "Age");
            DropColumn("dbo.ReceptionModels", "DateTime");
        }
    }
}
