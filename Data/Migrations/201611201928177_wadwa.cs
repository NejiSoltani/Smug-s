namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wadwa : DbMigration
    {
        public override void Up()
        {
            DropTable("crowd.dictionary");
        }
        
        public override void Down()
        {
            CreateTable(
                "crowd.dictionary",
                c => new
                    {
                        idDictionary = c.Int(nullable: false),
                        key = c.String(maxLength: 255, storeType: "nvarchar"),
                        value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDictionary);
            
        }
    }
}
