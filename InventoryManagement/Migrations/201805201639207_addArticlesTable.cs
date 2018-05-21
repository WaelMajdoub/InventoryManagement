namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addArticlesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(),
                        UnitPriceExcludingTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VatRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Picture = c.String(),
                        UnitPriceIncludingTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
