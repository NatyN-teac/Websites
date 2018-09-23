namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDepartmentToStaffProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffProfiles", "DepName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffProfiles", "DepName");
        }
    }
}
