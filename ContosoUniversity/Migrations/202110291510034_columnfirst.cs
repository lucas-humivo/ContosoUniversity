namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnfirst : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "First Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "First Name", newName: "FirstMidName");
        }
    }
}
