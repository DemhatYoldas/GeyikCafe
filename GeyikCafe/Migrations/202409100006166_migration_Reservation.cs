namespace GeyikCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_Reservation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "VideUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "VideUrl", c => c.String());
        }
    }
}
