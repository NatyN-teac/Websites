namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationToTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AnswerTables", "Answer", c => c.String(nullable: false, maxLength: 3050));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AnswerTables", "Answer", c => c.String());
        }
    }
}
