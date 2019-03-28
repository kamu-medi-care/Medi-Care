namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationOnDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppointmentModels", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.AppointmentModels", "NextDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AppointmentModels", "InDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AppointmentModels", "InDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AppointmentModels", "NextDate", c => c.String());
            DropColumn("dbo.AppointmentModels", "Age");
        }
    }
}
