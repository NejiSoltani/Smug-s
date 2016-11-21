namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wadwa1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dictionary",
                c => new
                    {
                        idDictionary = c.Int(nullable: false),
                        key = c.String(maxLength: 255, storeType: "nvarchar"),
                        val = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDictionary);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.dictionary");
        }
    }
}
