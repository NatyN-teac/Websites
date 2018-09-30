namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class regressional1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "DepartmentType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DepartmentType", c => c.String());
        }
    }
}
