namespace GeyikCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Communications", "TechEmail", c => c.String());
            AddColumn("dbo.Communications", "BookEmail", c => c.String());
            AddColumn("dbo.Communications", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Communications", "Location");
            DropColumn("dbo.Communications", "BookEmail");
            DropColumn("dbo.Communications", "TechEmail");
        }
    }
}
