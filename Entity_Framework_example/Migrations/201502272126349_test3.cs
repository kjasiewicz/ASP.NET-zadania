namespace Entity_Framework_example.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Telefony", "NrIndeksu", "dbo.Student");
            DropForeignKey("dbo.Adres", "NrIndeksu", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "NrIndeksu", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Student", "NrIndeksu");
            AddForeignKey("dbo.Telefony", "NrIndeksu", "dbo.Student", "NrIndeksu", cascadeDelete: true);
            AddForeignKey("dbo.Adres", "NrIndeksu", "dbo.Student", "NrIndeksu");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adres", "NrIndeksu", "dbo.Student");
            DropForeignKey("dbo.Telefony", "NrIndeksu", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "NrIndeksu", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Student", "NrIndeksu");
            AddForeignKey("dbo.Adres", "NrIndeksu", "dbo.Student", "NrIndeksu");
            AddForeignKey("dbo.Telefony", "NrIndeksu", "dbo.Student", "NrIndeksu", cascadeDelete: true);
        }
    }
}
