namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Departments", "Dep_Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Departments", "Dep_Related_Article", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Dep_Related_Article", c => c.String());
            AlterColumn("dbo.Departments", "Dep_Description", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
        }
    }
}
