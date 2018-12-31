namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flightmodelandcustomers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_Name = c.String(nullable: false),
                        Last_name = c.String(nullable: false),
                        email = c.String(nullable: false),
                        flightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.flightId, cascadeDelete: true)
                .Index(t => t.flightId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "flightId", "dbo.Flights");
            DropIndex("dbo.Customers", new[] { "flightId" });
            DropTable("dbo.Customers");
        }
    }
}
