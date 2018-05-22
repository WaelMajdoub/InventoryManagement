namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablePersons : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "People");
            AddColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "FirstName");
            DropColumn("dbo.People", "LastName");
            RenameTable(name: "dbo.People", newName: "Customers");
        }
    }
}
