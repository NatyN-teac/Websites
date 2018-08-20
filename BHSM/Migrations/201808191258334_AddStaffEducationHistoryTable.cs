namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStaffEducationHistoryTable : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffProfiles", t => t.StaffProfileId, cascadeDelete: true)
                .Index(t => t.StaffProfileId);
            
            DropTable("dbo.CHS_Staff");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CHS_Staff",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        MiddleName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        DescriptionBackground = c.String(nullable: false, maxLength: 1000),
                        E_Mail = c.String(nullable: false),
                        Address = c.String(),
                        OfficeAddress = c.String(nullable: false),
                        BirthDate = c.DateTime(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.StaffEducationHistories", "StaffProfileId", "dbo.StaffProfiles");
            DropIndex("dbo.StaffEducationHistories", new[] { "StaffProfileId" });
            DropTable("dbo.StaffEducationHistories");
        }
    }
}
