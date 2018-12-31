namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        flightNumber = c.String(nullable: false),
                        location = c.String(nullable: false),
                        destination = c.String(nullable: false),
                        aircrafttype = c.String(nullable: false),
                        Departure_date = c.DateTime(nullable: false),
                        Arrival_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Flights");
        }
    }
}
