namespace GeyikCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_MenuUpdate : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Menus", "MenuCategoryId");
            AddForeignKey("dbo.Menus", "MenuCategoryId", "dbo.MenuCategories", "MenuCategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "MenuCategoryId", "dbo.MenuCategories");
            DropIndex("dbo.Menus", new[] { "MenuCategoryId" });
        }
    }
}
