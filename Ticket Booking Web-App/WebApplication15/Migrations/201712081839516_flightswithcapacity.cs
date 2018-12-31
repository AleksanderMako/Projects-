namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flightswithcapacity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "flight_capacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flights", "flight_capacity");
        }
    }
}
