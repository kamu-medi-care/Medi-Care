namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsInMedicine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MedicineModels", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MedicineModels", "Qty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MedicineModels", "Qty");
            DropColumn("dbo.MedicineModels", "Price");
        }
    }
}
