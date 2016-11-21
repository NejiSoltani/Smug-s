namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v : DbMigration
    {
        public override void Up()
        {
            DropTable("question");
        }
        
        public override void Down()
        {
            CreateTable(
                "crowd.question",
                c => new
                    {
                        idQuestion = c.Int(nullable: false),
                        answer = c.String(maxLength: 255, storeType: "nvarchar"),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        photo = c.String(maxLength: 255, storeType: "nvarchar"),
                        quiz_idQuiz = c.Int(),
                    })
                .PrimaryKey(t => t.idQuestion);
            
        }
    }
}
