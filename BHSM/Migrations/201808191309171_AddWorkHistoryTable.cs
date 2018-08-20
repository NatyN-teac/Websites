namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkHistoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartYear = c.String(),
                        EndYear = c.String(),
                        JobTitle = c.String(),
                        Institution = c.String(),
                        StaffProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffProfiles", t => t.StaffProfileId, cascadeDelete: true)
                .Index(t => t.StaffProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkHistories", "StaffProfileId", "dbo.StaffProfiles");
            DropIndex("dbo.WorkHistories", new[] { "StaffProfileId" });
            DropTable("dbo.WorkHistories");
        }
    }
}
