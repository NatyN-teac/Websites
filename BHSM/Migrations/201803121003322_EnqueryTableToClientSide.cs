namespace BHSM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnqueryTableToClientSide : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnswerTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnqueryTableId = c.Int(nullable: false),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EnqueryTables", t => t.EnqueryTableId, cascadeDelete: true)
                .Index(t => t.EnqueryTableId);
            
            CreateTable(
                "dbo.EnqueryTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        SecondName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        location = c.String(),
                        Question = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnswerTables", "EnqueryTableId", "dbo.EnqueryTables");
            DropIndex("dbo.AnswerTables", new[] { "EnqueryTableId" });
            DropTable("dbo.EnqueryTables");
            DropTable("dbo.AnswerTables");
        }
    }
}
