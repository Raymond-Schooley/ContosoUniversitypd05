namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGpaToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Gpa", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Gpa");
        }
    }
}
