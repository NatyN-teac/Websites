namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DepartmentListId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "DepartmentListId");
            AddForeignKey("dbo.AspNetUsers", "DepartmentListId", "dbo.DepartmentLists", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "DepartmentListId", "dbo.DepartmentLists");
            DropIndex("dbo.AspNetUsers", new[] { "DepartmentListId" });
            DropColumn("dbo.AspNetUsers", "DepartmentListId");
        }
    }
}
