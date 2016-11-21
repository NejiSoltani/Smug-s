namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wadwa1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "crowd.contact", name: "idFeedBack", newName: "idContact");
        }
        
        public override void Down()
        {
            RenameColumn(table: "crowd.contact", name: "idContact", newName: "idFeedBack");
        }
    }
}
