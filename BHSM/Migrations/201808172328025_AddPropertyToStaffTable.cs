namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyToStaffTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffProfiles", "Specialization", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StaffProfiles", "Specialization");
        }
    }
}
