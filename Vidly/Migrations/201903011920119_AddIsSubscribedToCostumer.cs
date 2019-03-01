namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCostumer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubscribedToNewsLetter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "isSubscribed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "isSubscribed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "isSubscribedToNewsLetter");
        }
    }
}
