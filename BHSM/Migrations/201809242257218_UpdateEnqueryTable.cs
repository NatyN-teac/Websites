namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEnqueryTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EnqueryTables", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EnqueryTables", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
