namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "crowd.category",
                c => new
                    {
                        idCategory = c.Int(nullable: false),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        manager_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idCategory);
            
            CreateTable(
                "crowd.category_customer",
                c => new
                    {
                        categories_idCategory = c.Int(nullable: false),
                        customers_idUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.categories_idCategory, t.customers_idUser });
            
            CreateTable(
                "crowd.category_user",
                c => new
                    {
                        categories_idCategory = c.Int(nullable: false),
                        customers_idUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.categories_idCategory, t.customers_idUser });
            
            CreateTable(
                "crowd.comment",
                c => new
                    {
                        idComment = c.Int(nullable: false),
                        content = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.DateTime(precision: 0),
                        customer_idUser = c.Int(),
                        idea_idIdea = c.Int(),
                        manager_idUser = c.Int(),
                        photo_idPhoto = c.Int(),
                    })
                .PrimaryKey(t => t.idComment);
            
            CreateTable(
                "crowd.customer",
                c => new
                    {
                        idUser = c.Int(nullable: false),
                        ban = c.Boolean(nullable: false),
                        birthday = c.DateTime(precision: 0),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                        gender = c.String(maxLength: 255, storeType: "nvarchar"),
                        inscriptionDate = c.DateTime(precision: 0),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        tel = c.Int(nullable: false),
                        score = c.Int(nullable: false),
                        manager_idUser = c.Int(),
                        manager1_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "crowd.feedback",
                c => new
                    {
                        idFeedBack = c.Int(nullable: false),
                        content = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.DateTime(precision: 0),
                        customer_idUser = c.Int(),
                        reviewer_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idFeedBack);
            
            CreateTable(
                "crowd.ideareviewer",
                c => new
                    {
                        idUser = c.Int(nullable: false),
                        ban = c.Boolean(nullable: false),
                        birthday = c.DateTime(precision: 0),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                        gender = c.String(maxLength: 255, storeType: "nvarchar"),
                        inscriptionDate = c.DateTime(precision: 0),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        tel = c.Int(nullable: false),
                        idReviewer = c.Int(nullable: false),
                        manager_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "crowd.idea",
                c => new
                    {
                        idIdea = c.Int(nullable: false, identity: true),
                        content = c.String(maxLength: 255, storeType: "nvarchar"),
                        dateDepot = c.DateTime(precision: 0),
                        statut = c.String(maxLength: 255, storeType: "nvarchar"),
                        subject = c.String(maxLength: 255, storeType: "nvarchar"),
                        customer_idUser = c.Int(),
                        manager_idUser = c.Int(),
                        reviewer_idUser = c.Int(),
                        manager1_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idIdea);
            
            CreateTable(
                "crowd.like2",
                c => new
                    {
                        idLike = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        customer_idUser = c.Int(),
                        idea_idIdea = c.Int(),
                        photo_idPhoto = c.Int(),
                    })
                .PrimaryKey(t => t.idLike);
            
            CreateTable(
                "crowd.marketingmanager",
                c => new
                    {
                        idUser = c.Int(nullable: false),
                        ban = c.Boolean(nullable: false),
                        birthday = c.DateTime(precision: 0),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                        gender = c.String(maxLength: 255, storeType: "nvarchar"),
                        inscriptionDate = c.DateTime(precision: 0),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        tel = c.Int(nullable: false),
                        idManager = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "crowd.photo",
                c => new
                    {
                        idPhoto = c.Int(nullable: false),
                        Picture = c.String(maxLength: 255, storeType: "nvarchar"),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        customer_idUser = c.Int(),
                        manager_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idPhoto);
            
            CreateTable(
                "crowd.prize",
                c => new
                    {
                        idPrize = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        customer_idUser = c.Int(),
                        reviewer_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idPrize);
            
            CreateTable(
                "crowd.product",
                c => new
                    {
                        idProduct = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        photo = c.String(maxLength: 255, storeType: "nvarchar"),
                        price = c.Single(),
                        score = c.Int(nullable: false),
                        category_idCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idProduct);
            
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
            
            CreateTable(
                "crowd.quiz",
                c => new
                    {
                        idQuiz = c.Int(nullable: false, identity: true),
                        endDate = c.DateTime(precision: 0),
                        score = c.Int(nullable: false),
                        startDate = c.DateTime(precision: 0),
                        customer_idUser = c.Int(),
                        reviewer_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idQuiz);
            
            CreateTable(
                "crowd.reclamation",
                c => new
                    {
                        idReclamation = c.Int(nullable: false, identity: true),
                        content = c.String(maxLength: 255, storeType: "nvarchar"),
                        dateReclamation = c.DateTime(precision: 0),
                        subject = c.String(maxLength: 255, storeType: "nvarchar"),
                        customer_idUser = c.Int(),
                        manager_idUser = c.Int(),
                        type = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idReclamation);
            
            CreateTable(
                "crowd.reservation",
                c => new
                    {
                        idReservation = c.Int(nullable: false),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        number = c.Int(nullable: false),
                        customer_idUser = c.Int(),
                        shop_idShop = c.Int(),
                    })
                .PrimaryKey(t => t.idReservation);
            
            CreateTable(
                "crowd.shop",
                c => new
                    {
                        idShop = c.Int(nullable: false),
                        address = c.String(maxLength: 255, storeType: "nvarchar"),
                        lat = c.String(maxLength: 255, storeType: "nvarchar"),
                        lng = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        phone = c.Int(nullable: false),
                        photo = c.String(maxLength: 255, storeType: "nvarchar"),
                        score = c.Single(nullable: false),
                        category_idCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idShop);
            
            CreateTable(
                "crowd.t_todo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        text = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "crowd.user",
                c => new
                    {
                        idUser = c.Int(nullable: false),
                        DTYPE = c.String(nullable: false, maxLength: 31, storeType: "nvarchar"),
                        ban = c.Boolean(nullable: false),
                        birthday = c.DateTime(precision: 0),
                        email = c.String(maxLength: 255, storeType: "nvarchar"),
                        firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                        gender = c.String(maxLength: 255, storeType: "nvarchar"),
                        inscriptionDate = c.DateTime(precision: 0),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        tel = c.Int(nullable: false),
                        idCustomer = c.Int(),
                        score = c.Int(),
                        idManager = c.Int(),
                        idReviewer = c.Int(),
                        manager_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idUser);
            
        }
        
        public override void Down()
        {
            DropTable("crowd.user");
            DropTable("crowd.t_todo");
            DropTable("crowd.shop");
            DropTable("crowd.reservation");
            DropTable("crowd.reclamation");
            DropTable("crowd.quiz");
            DropTable("crowd.question");
            DropTable("crowd.product");
            DropTable("crowd.prize");
            DropTable("crowd.photo");
            DropTable("crowd.marketingmanager");
            DropTable("crowd.like2");
            DropTable("crowd.idea");
            DropTable("crowd.ideareviewer");
            DropTable("crowd.feedback");
            DropTable("crowd.customer");
            DropTable("crowd.comment");
            DropTable("crowd.category_user");
            DropTable("crowd.category_customer");
            DropTable("crowd.category");
        }
    }
}
