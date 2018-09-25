namespace Monstrosity.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Activity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivityState",
                c => new
                    {
                        ActivityStateId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityStateId);
            
            AddColumn("dbo.Activity", "DateFrom", c => c.DateTime(nullable: false));
            AddColumn("dbo.Activity", "DateTo", c => c.DateTime());
            AddColumn("dbo.Activity", "ActivityStateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Activity", "ActivityStateId");
            AddForeignKey("dbo.Activity", "ActivityStateId", "dbo.ActivityState", "ActivityStateId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activity", "ActivityStateId", "dbo.ActivityState");
            DropIndex("dbo.Activity", new[] { "ActivityStateId" });
            DropColumn("dbo.Activity", "ActivityStateId");
            DropColumn("dbo.Activity", "DateTo");
            DropColumn("dbo.Activity", "DateFrom");
            DropTable("dbo.ActivityState");
        }
    }
}
