namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        GigId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                        Attendde_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.GigId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.Attendde_Id)
                .ForeignKey("dbo.Gigs", t => t.GigId)
                .Index(t => t.GigId)
                .Index(t => t.Attendde_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "GigId", "dbo.Gigs");
            DropForeignKey("dbo.Attendances", "Attendde_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "Attendde_Id" });
            DropIndex("dbo.Attendances", new[] { "GigId" });
            DropTable("dbo.Attendances");
        }
    }
}
