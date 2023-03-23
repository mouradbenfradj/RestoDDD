namespace DDD.infra.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        prenom = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        login = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        mdp = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Affectation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        villedep = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        villearr = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        nbrplace = c.Int(nullable: false),
                        id_conduc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Conducteur", t => t.id_conduc, cascadeDelete: true)
                .Index(t => t.id_conduc);
            
            CreateTable(
                "dbo.Conducteur",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        prenom = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        cin = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        tel = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        login = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        mdp = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        voiture = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Reclamation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        id_conduc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Conducteur", t => t.id_conduc, cascadeDelete: true)
                .Index(t => t.id_conduc);
            
            CreateTable(
                "dbo.Passager",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        prenom = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        cin = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        tel = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        login = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        mdp = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        id_aff = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Affectation", t => t.id_aff, cascadeDelete: true)
                .Index(t => t.id_aff);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passager", "id_aff", "dbo.Affectation");
            DropForeignKey("dbo.Affectation", "id_conduc", "dbo.Conducteur");
            DropForeignKey("dbo.Reclamation", "id_conduc", "dbo.Conducteur");
            DropIndex("dbo.Passager", new[] { "id_aff" });
            DropIndex("dbo.Reclamation", new[] { "id_conduc" });
            DropIndex("dbo.Affectation", new[] { "id_conduc" });
            DropTable("dbo.Passager");
            DropTable("dbo.Reclamation");
            DropTable("dbo.Conducteur");
            DropTable("dbo.Affectation");
            DropTable("dbo.Admin");
        }
    }
}
