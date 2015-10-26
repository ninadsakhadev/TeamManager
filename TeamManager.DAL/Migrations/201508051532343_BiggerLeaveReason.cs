namespace TeamManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BiggerLeaveReason : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Leaves", "Reason", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Leaves", "Reason", c => c.String(nullable: false, maxLength: 256));
        }
    }
}
