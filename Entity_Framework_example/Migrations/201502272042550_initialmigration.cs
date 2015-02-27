namespace Entity_Framework_example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        NrIndeksu = c.Int(nullable: false),
                        Ulica = c.String(),
                        Numer = c.String(),
                        KodPocztowy = c.String(),
                    })
                .PrimaryKey(t => t.NrIndeksu)
                .ForeignKey("dbo.Student", t => t.NrIndeksu)
                .Index(t => t.NrIndeksu);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        NrIndeksu = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                    })
                .PrimaryKey(t => t.NrIndeksu);
            
            CreateTable(
                "dbo.Telefony",
                c => new
                    {
                        Numer = c.Int(nullable: false, identity: true),
                        Operator = c.String(),
                        CzyKomorkowy = c.Boolean(nullable: false),
                        NrIndeksu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Numer)
                .ForeignKey("dbo.Student", t => t.NrIndeksu, cascadeDelete: true)
                .Index(t => t.NrIndeksu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adres", "NrIndeksu", "dbo.Student");
            DropForeignKey("dbo.Telefony", "NrIndeksu", "dbo.Student");
            DropIndex("dbo.Telefony", new[] { "NrIndeksu" });
            DropIndex("dbo.Adres", new[] { "NrIndeksu" });
            DropTable("dbo.Telefony");
            DropTable("dbo.Student");
            DropTable("dbo.Adres");
        }
    }
}
