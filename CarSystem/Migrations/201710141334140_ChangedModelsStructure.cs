namespace CarSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModelsStructure : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Make", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Cars", "Model", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Cars", "Type", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Cars", "Transmission", c => c.String(maxLength: 255));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Cars", "Transmission", c => c.String());
            AlterColumn("dbo.Cars", "Type", c => c.String());
            AlterColumn("dbo.Cars", "Model", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Cars", "Make", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
