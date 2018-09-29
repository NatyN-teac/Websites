namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEnqueryTabless : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EnqueryTables", "Answer", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EnqueryTables", "Answer", c => c.String(maxLength: 3000));
        }
    }
}
