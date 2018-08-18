namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStaffProfileTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        imageUrl = c.String(nullable: false),
                        DepartmentId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId_Id)
                .Index(t => t.DepartmentId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaffProfiles", "DepartmentId_Id", "dbo.Departments");
            DropIndex("dbo.StaffProfiles", new[] { "DepartmentId_Id" });
            DropTable("dbo.StaffProfiles");
        }
    }
}
