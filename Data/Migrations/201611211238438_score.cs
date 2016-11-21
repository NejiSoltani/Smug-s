namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class score : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.score",
                c => new
                    {
                        ScoreId = c.Int(nullable: false, identity: true),
                        challenge = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ScoreId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.scores");
        }
    }
}
