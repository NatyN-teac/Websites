namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateModelOFDepartment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepatmentMoto", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepartmentDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepartmentImageUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "DepartmentImageUrl", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentDescription", c => c.String());
            AlterColumn("dbo.Departments", "DepatmentMoto", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
        }
    }
}
