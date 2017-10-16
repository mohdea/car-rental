namespace CarSystem.Migrations
{
    using CarSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarSystem.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarSystem.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
                context.Employee.AddOrUpdate(                  
                  new Employee { Name = "Andrew Peters" , Email = "Andrew@gmail.com" },
                  new Employee { Name = "Brice Lambson" , Email = "Brice@gmail.com" },
                  new Employee { Name = "Rowan Miller" , Email = "Rowan@gmail.co" }
                );


        }
    }
}   
