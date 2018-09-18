namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDepartmentModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentDescription", c => c.String(nullable: false, maxLength: 1000));
            DropColumn("dbo.Departments", "DepartmentImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "DepartmentImageUrl", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentDescription", c => c.String(nullable: false));
        }
    }
}
