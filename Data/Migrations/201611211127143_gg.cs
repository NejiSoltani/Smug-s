namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.questions",
                c => new
                    {
                        idQuestion = c.Int(nullable: false, identity: true),
                        answer = c.String(unicode: false),
                        description = c.String(unicode: false),
                        photo = c.String(unicode: false),
                        quiz_idQuiz = c.Int(),
                    })
                .PrimaryKey(t => t.idQuestion);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.questions");
        }
    }
}
