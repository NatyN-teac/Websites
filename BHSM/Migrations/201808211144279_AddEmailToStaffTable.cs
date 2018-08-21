namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToStaffTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffProfiles", "Email", c => c.String(nullable: false));
            AddColumn("dbo.StaffProfiles", "Office", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffProfiles", "Office");
            DropColumn("dbo.StaffProfiles", "Email");
        }
    }
}
