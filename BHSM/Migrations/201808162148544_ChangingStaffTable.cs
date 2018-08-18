namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingStaffTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StaffProfiles", "DepartmentId_Id", "dbo.Departments");
            DropIndex("dbo.StaffProfiles", new[] { "DepartmentId_Id" });
            RenameColumn(table: "dbo.StaffProfiles", name: "DepartmentId_Id", newName: "DepartmentId");
            AlterColumn("dbo.StaffProfiles", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StaffProfiles", "DepartmentId");
            AddForeignKey("dbo.StaffProfiles", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffProfiles", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.StaffProfiles", new[] { "DepartmentId" });
            AlterColumn("dbo.StaffProfiles", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.StaffProfiles", name: "DepartmentId", newName: "DepartmentId_Id");
            CreateIndex("dbo.StaffProfiles", "DepartmentId_Id");
            AddForeignKey("dbo.StaffProfiles", "DepartmentId_Id", "dbo.Departments", "Id");
        }
    }
}
