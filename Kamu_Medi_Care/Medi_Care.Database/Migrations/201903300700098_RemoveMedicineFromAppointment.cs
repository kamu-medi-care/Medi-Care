namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMedicineFromAppointment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AppointmentModels", "Medicine");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AppointmentModels", "Medicine", c => c.String());
        }
    }
}
