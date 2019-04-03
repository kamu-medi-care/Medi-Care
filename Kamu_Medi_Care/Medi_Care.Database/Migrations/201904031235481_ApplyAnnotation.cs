namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppointmentModels", "PrevDate", c => c.String());
            AlterColumn("dbo.AppointmentModels", "NextDate", c => c.String());
            AlterColumn("dbo.ReceptionModels", "DateTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReceptionModels", "DateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AppointmentModels", "NextDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AppointmentModels", "PrevDate", c => c.DateTime(nullable: false));
        }
    }
}
