namespace Monstrosity.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contact_ContactType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(),
                        FatherName = c.String(),
                        DoB = c.DateTime(),
                        ContactTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId)
                .ForeignKey("dbo.ContactType", t => t.ContactTypeId, cascadeDelete: false)
                .Index(t => t.ContactTypeId);
            
            CreateTable(
                "dbo.ContactType",
                c => new
                    {
                        ContactTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContactTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contact", "ContactTypeId", "dbo.ContactType");
            DropIndex("dbo.Contact", new[] { "ContactTypeId" });
            DropTable("dbo.ContactType");
            DropTable("dbo.Contact");
        }
    }
}
