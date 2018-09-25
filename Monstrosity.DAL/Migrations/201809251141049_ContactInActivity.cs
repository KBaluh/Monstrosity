namespace Monstrosity.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactInActivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activity", "ContactId", c => c.Int(nullable: true));
            CreateIndex("dbo.Activity", "ContactId");
            AddForeignKey("dbo.Activity", "ContactId", "dbo.Contact", "ContactId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activity", "ContactId", "dbo.Contact");
            DropIndex("dbo.Activity", new[] { "ContactId" });
            DropColumn("dbo.Activity", "ContactId");
        }
    }
}
