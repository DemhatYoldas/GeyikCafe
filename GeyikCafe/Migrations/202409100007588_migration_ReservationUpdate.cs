namespace GeyikCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_ReservationUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Header");
            DropColumn("dbo.Reservations", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Title", c => c.String());
            AddColumn("dbo.Reservations", "Header", c => c.String());
        }
    }
}
