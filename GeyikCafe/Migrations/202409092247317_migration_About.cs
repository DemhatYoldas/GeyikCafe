namespace GeyikCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_About : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutBigImageOneUrl", c => c.String());
            AddColumn("dbo.Abouts", "AboutBigImageTwoUrl", c => c.String());
            AddColumn("dbo.Abouts", "AboutBigImagethirdUrl", c => c.String());
            AddColumn("dbo.Abouts", "AboutBigImagefourthUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "AboutBigImagefourthUrl");
            DropColumn("dbo.Abouts", "AboutBigImagethirdUrl");
            DropColumn("dbo.Abouts", "AboutBigImageTwoUrl");
            DropColumn("dbo.Abouts", "AboutBigImageOneUrl");
        }
    }
}
