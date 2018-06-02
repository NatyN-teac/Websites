namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnotationToEnquery1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EnqueryTables", "location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EnqueryTables", "location", c => c.String());
        }
    }
}
