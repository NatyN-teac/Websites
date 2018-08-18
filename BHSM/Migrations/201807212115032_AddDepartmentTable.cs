namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "DepartmentListId", "dbo.DepartmentLists");
            DropIndex("dbo.AspNetUsers", new[] { "DepartmentListId" });
            AddColumn("dbo.Departments", "DepatmentMoto", c => c.String());
            AddColumn("dbo.Departments", "DepartmentDescription", c => c.String());
            AddColumn("dbo.Departments", "DepartmentImageUrl", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
            DropColumn("dbo.Departments", "Dep_Description");
            DropColumn("dbo.Departments", "Dep_Related_Article");
            DropColumn("dbo.Departments", "Dep_ImagePath");
            DropColumn("dbo.AspNetUsers", "DepartmentListId");
            DropTable("dbo.DepartmentLists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DepartmentLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Dep_Summary = c.String(),
                        Dep_Article = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "DepartmentListId", c => c.Int());
            AddColumn("dbo.Departments", "Dep_ImagePath", c => c.String());
            AddColumn("dbo.Departments", "Dep_Related_Article", c => c.String(nullable: false, maxLength: 300));
            AddColumn("dbo.Departments", "Dep_Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Departments", "DepartmentImageUrl");
            DropColumn("dbo.Departments", "DepartmentDescription");
            DropColumn("dbo.Departments", "DepatmentMoto");
            CreateIndex("dbo.AspNetUsers", "DepartmentListId");
            AddForeignKey("dbo.AspNetUsers", "DepartmentListId", "dbo.DepartmentLists", "Id");
        }
    }
}
