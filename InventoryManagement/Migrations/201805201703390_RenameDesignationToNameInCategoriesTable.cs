namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDesignationToNameInCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.Categories", "Designation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Designation", c => c.String());
            DropColumn("dbo.Categories", "Name");
        }
    }
}
