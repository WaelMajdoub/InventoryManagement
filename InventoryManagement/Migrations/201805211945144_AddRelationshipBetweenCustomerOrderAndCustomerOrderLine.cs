namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationshipBetweenCustomerOrderAndCustomerOrderLine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerOrderLines", "CustomerOrderId", c => c.Long(nullable: false));
            CreateIndex("dbo.CustomerOrderLines", "CustomerOrderId");
            AddForeignKey("dbo.CustomerOrderLines", "CustomerOrderId", "dbo.CustomerOrders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrderLines", "CustomerOrderId", "dbo.CustomerOrders");
            DropIndex("dbo.CustomerOrderLines", new[] { "CustomerOrderId" });
            DropColumn("dbo.CustomerOrderLines", "CustomerOrderId");
        }
    }
}
