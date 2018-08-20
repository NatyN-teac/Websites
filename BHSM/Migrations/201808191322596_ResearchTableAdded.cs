namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResearchTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContributionToScienceAndResearches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Role = c.String(),
                        StartYear = c.String(),
                        EndYear = c.String(),
                        ReferrenceLink = c.String(),
                        StaffProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffProfiles", t => t.StaffProfileId, cascadeDelete: true)
                .Index(t => t.StaffProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContributionToScienceAndResearches", "StaffProfileId", "dbo.StaffProfiles");
            DropIndex("dbo.ContributionToScienceAndResearches", new[] { "StaffProfileId" });
            DropTable("dbo.ContributionToScienceAndResearches");
        }
    }
}
