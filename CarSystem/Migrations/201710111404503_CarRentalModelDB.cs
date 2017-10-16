namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarRentalModelDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarRentals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        RentalDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        paidAmount = c.Int(nullable: false),
                        ActualReturnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarRentals");
        }
    }
}
