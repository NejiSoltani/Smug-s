namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wadwa : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.notification",
                c => new
                    {
                        idNotification = c.Int(nullable: false),
                        content = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.DateTime(precision: 0),
                        customer_idUser = c.Int(),
                        reviewer_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idNotification);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.notification");
           
        }
    }
}
