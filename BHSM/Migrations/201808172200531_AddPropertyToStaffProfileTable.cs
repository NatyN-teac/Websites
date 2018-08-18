namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyToStaffProfileTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffProfiles", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.StaffProfiles", "Nationality", c => c.String(nullable: false));
            AddColumn("dbo.StaffProfiles", "AcademicRank", c => c.String(nullable: false));
            AddColumn("dbo.StaffProfiles", "Status", c => c.String(nullable: false));
            AddColumn("dbo.StaffProfiles", "PersonalStatement", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffProfiles", "PersonalStatement");
            DropColumn("dbo.StaffProfiles", "Status");
            DropColumn("dbo.StaffProfiles", "AcademicRank");
            DropColumn("dbo.StaffProfiles", "Nationality");
            DropColumn("dbo.StaffProfiles", "Gender");
        }
    }
}
