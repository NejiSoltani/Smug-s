namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class salima : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.idea", " isReported", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.idea", " isReported");
        }
    }
}
