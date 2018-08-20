namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateStaffProfileTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AssociationMemberships", "StaffProfileId", "dbo.StaffProfiles");
            DropForeignKey("dbo.ContributionToScienceAndResearches", "StaffProfileId", "dbo.StaffProfiles");
            DropForeignKey("dbo.StaffEducationHistories", "StaffProfileId", "dbo.StaffProfiles");
            DropForeignKey("dbo.WorkHistories", "StaffProfileId", "dbo.StaffProfiles");
            DropIndex("dbo.AssociationMemberships", new[] { "StaffProfileId" });
            DropIndex("dbo.ContributionToScienceAndResearches", new[] { "StaffProfileId" });
            DropIndex("dbo.StaffEducationHistories", new[] { "StaffProfileId" });
            DropIndex("dbo.WorkHistories", new[] { "StaffProfileId" });
            AddColumn("dbo.StaffProfiles", "AdditionalResponsibility", c => c.String());
            AddColumn("dbo.StaffProfiles", "EducationalBackground", c => c.String());
            AddColumn("dbo.StaffProfiles", "WorkHistory", c => c.String());
            AddColumn("dbo.StaffProfiles", "ContributionToScienceAndResearch", c => c.String());
            AddColumn("dbo.StaffProfiles", "LinkdenLink", c => c.String());
            DropTable("dbo.AssociationMemberships");
            DropTable("dbo.ContributionToScienceAndResearches");
            DropTable("dbo.StaffEducationHistories");
            DropTable("dbo.WorkHistories");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaffEducationHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DegreeName = c.String(nullable: false),
                        CompletionYear = c.String(nullable: false),
                        FieldOfStudy = c.String(nullable: false),
                        StaffProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AssociationMemberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartYear = c.String(),
                        Description = c.String(),
                        StaffProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.StaffProfiles", "LinkdenLink");
            DropColumn("dbo.StaffProfiles", "ContributionToScienceAndResearch");
            DropColumn("dbo.StaffProfiles", "WorkHistory");
            DropColumn("dbo.StaffProfiles", "EducationalBackground");
            DropColumn("dbo.StaffProfiles", "AdditionalResponsibility");
            CreateIndex("dbo.WorkHistories", "StaffProfileId");
            CreateIndex("dbo.StaffEducationHistories", "StaffProfileId");
            CreateIndex("dbo.ContributionToScienceAndResearches", "StaffProfileId");
            CreateIndex("dbo.AssociationMemberships", "StaffProfileId");
            AddForeignKey("dbo.WorkHistories", "StaffProfileId", "dbo.StaffProfiles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StaffEducationHistories", "StaffProfileId", "dbo.StaffProfiles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ContributionToScienceAndResearches", "StaffProfileId", "dbo.StaffProfiles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AssociationMemberships", "StaffProfileId", "dbo.StaffProfiles", "Id", cascadeDelete: true);
        }
    }
}
