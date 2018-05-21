namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKeyCategoryIdToArticlesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Articles", "Category_Id", c => c.Long());
            CreateIndex("dbo.Articles", "Category_Id");
            AddForeignKey("dbo.Articles", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Articles", new[] { "Category_Id" });
            DropColumn("dbo.Articles", "Category_Id");
            DropColumn("dbo.Articles", "CategoryId");
        }
    }
}
