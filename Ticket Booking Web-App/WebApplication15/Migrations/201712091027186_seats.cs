namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        row = c.Int(nullable: false),
                        seatLetter = c.String(nullable: false),
                        whatflightId = c.Int(nullable: false),
                        idoftheCustomer = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.whatflightId, cascadeDelete: true)
                .Index(t => t.whatflightId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "whatflightId", "dbo.Flights");
            DropIndex("dbo.Seats", new[] { "whatflightId" });
            DropTable("dbo.Seats");
        }
    }
}
