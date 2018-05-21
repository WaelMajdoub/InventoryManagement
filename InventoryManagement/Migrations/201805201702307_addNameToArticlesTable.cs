namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNameToArticlesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "Name");
        }
    }
}
