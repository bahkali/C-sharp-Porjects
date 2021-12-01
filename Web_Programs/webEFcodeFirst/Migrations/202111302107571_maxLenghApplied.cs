namespace webEFcodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maxLenghApplied : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "ClassName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Students", "StudentName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String());
            AlterColumn("dbo.Courses", "ClassName", c => c.String());
        }
    }
}
