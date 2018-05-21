namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomerOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerOrders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerOrders", new[] { "CustomerId" });
            DropTable("dbo.CustomerOrders");
        }
    }
}
