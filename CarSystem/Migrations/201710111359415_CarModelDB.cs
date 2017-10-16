namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarModelDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Make = c.String(nullable: false, maxLength: 255),
                        Model = c.String(nullable: false, maxLength: 255),
                        Year = c.Int(nullable: false),
                        Type = c.String(),
                        Transmission = c.String(),
                        RatePerDay = c.Int(nullable: false),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
