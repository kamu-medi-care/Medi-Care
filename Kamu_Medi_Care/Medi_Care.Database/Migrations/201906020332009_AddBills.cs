namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineId = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qty = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalBill = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BillModels");
        }
    }
}
