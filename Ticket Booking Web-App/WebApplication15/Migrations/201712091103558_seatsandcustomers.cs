namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seatsandcustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SeatLetter", c => c.String());
            AddColumn("dbo.Customers", "rowseat", c => c.Int(nullable: false));
            AddColumn("dbo.Seats", "seatcapacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Seats", "seatcapacity");
            DropColumn("dbo.Customers", "rowseat");
            DropColumn("dbo.Customers", "SeatLetter");
        }
    }
}
