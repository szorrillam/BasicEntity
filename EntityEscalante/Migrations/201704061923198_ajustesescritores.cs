namespace EntityEscalante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajustesescritores : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Escritors", newName: "Escritores");
            AlterColumn("dbo.Escritores", "Nombre", c => c.String(maxLength: 100));
            AlterColumn("dbo.Escritores", "Pais", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Escritores", "Pais", c => c.String());
            AlterColumn("dbo.Escritores", "Nombre", c => c.String());
            RenameTable(name: "dbo.Escritores", newName: "Escritors");
        }
    }
}
