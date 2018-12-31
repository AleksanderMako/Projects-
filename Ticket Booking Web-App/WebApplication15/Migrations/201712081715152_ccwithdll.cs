namespace WebApplication15.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ccwithdll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.creditcards",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email_address = c.String(nullable: false),
                        creditcard_number = c.String(),
                        cvc = c.String(),
                        Card_Holder = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.creditcards");
        }
    }
}
