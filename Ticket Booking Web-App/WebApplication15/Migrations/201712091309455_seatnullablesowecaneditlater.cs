namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seatnullablesowecaneditlater : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "rowseat", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "rowseat", c => c.Int(nullable: false));
        }
    }
}
