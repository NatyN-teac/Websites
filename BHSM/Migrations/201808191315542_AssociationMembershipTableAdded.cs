namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssociationMembershipTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssociationMemberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartYear = c.String(),
                        Description = c.String(),
                        StaffProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffProfiles", t => t.StaffProfileId, cascadeDelete: true)
                .Index(t => t.StaffProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssociationMemberships", "StaffProfileId", "dbo.StaffProfiles");
            DropIndex("dbo.AssociationMemberships", new[] { "StaffProfileId" });
            DropTable("dbo.AssociationMemberships");
        }
    }
}
