namespace oblik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOblikMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaterialValuesDTOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameMaterialValues = c.String(),
                        ReceiptDate = c.DateTime(nullable: false),
                        RemoveDate = c.DateTime(nullable: false),
                        YearIssue = c.String(),
                        Count = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sum = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        PlaceStorage = c.String(),
                        ResponsiblePerson = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MaterialValuesDTOes");
        }
    }
}
