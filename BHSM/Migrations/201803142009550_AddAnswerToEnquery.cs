namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnswerToEnquery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EnqueryTables", "Answer", c => c.String(maxLength: 3000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EnqueryTables", "Answer");
        }
    }
}
