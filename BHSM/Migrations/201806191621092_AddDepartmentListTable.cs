namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentListTable : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DepartmentLists");
        }
    }
}
