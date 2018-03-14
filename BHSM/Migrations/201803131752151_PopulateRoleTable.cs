namespace BHSM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateRoleTable : DbMigration
    {
        public override void Up()
        {
            Sql("set  IDENTITY_INSERT ChsRoles ON");
            Sql("INSERT INTO ChsRoles(Id, Name) VALUES(1,'Doctor')");
            Sql("INSERT INTO ChsRoles(Id, Name) VALUES(2,'Nurse')");
            Sql("INSERT INTO ChsRoles(Id, Name) VALUES(3,'Professor')");
            Sql("INSERT INTO ChsRoles(Id, Name) VALUES(4,'Department Chairman')");
            Sql("INSERT INTO ChsRoles(Id, Name) VALUES(5,'Dean')");
            Sql("INSERT INTO ChsRoles(Id, Name) VALUES(6,'other')");
        }
        
        public override void Down()
        {
        }
    }
}
