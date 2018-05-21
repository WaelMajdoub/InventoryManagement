namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationshipBetweenArticleAndCustomerOrderLine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerOrderLines", "ArticleId", c => c.Long(nullable: false));
            CreateIndex("dbo.CustomerOrderLines", "ArticleId");
            AddForeignKey("dbo.CustomerOrderLines", "ArticleId", "dbo.Articles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerOrderLines", "ArticleId", "dbo.Articles");
            DropIndex("dbo.CustomerOrderLines", new[] { "ArticleId" });
            DropColumn("dbo.CustomerOrderLines", "ArticleId");
        }
    }
}
