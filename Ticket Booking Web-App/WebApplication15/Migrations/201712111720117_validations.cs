namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.creditcards", "creditcard_number", c => c.String(nullable: false));
            AlterColumn("dbo.creditcards", "cvc", c => c.String(nullable: false));
            AlterColumn("dbo.creditcards", "Card_Holder", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.creditcards", "Card_Holder", c => c.String());
            AlterColumn("dbo.creditcards", "cvc", c => c.String());
            AlterColumn("dbo.creditcards", "creditcard_number", c => c.String());
        }
    }
}
