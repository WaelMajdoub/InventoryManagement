namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCategoriesTable : DbMigration
    {
        public override void Up()
        {
	        Sql("INSERT INTO Categories (Name) VALUES ('SPORT') ");
	        Sql("INSERT INTO Categories (Name) VALUES ('Loisir') ");
		}
        
        public override void Down()
        {
	        Sql("DELETE FROM Categories WHERE Id In (1,2) ");
				}
    }
}
