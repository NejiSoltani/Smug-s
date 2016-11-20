namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wqdwq : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.comment", "reported", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.comment", "reported");
        }
    }
}
