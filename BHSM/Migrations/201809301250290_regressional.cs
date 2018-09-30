namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class regressional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "DepartmentType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "DepartmentType", c => c.String(nullable: false));
        }
    }
}
