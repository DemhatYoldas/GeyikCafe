namespace GeyikCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_Menu : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "MenuCategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "MenuCategoryId", c => c.String());
        }
    }
}
