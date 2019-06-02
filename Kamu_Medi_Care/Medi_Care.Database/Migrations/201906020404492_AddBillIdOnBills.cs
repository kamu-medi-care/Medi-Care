namespace Medi_Care.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBillIdOnBills : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BillModels", "BillId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BillModels", "BillId");
        }
    }
}
