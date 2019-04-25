namespace Medi_Care.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPatientIdInAppointment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppointmentModels", "PatientId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppointmentModels", "PatientId");
        }
    }
}
