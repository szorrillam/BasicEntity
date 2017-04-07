namespace EntityEscalante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class libros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        ISBN = c.String(nullable: false, maxLength: 20),
                        EscritorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escritores", t => t.EscritorId, cascadeDelete: true)
                .Index(t => t.EscritorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libros", "EscritorId", "dbo.Escritores");
            DropIndex("dbo.Libros", new[] { "EscritorId" });
            DropTable("dbo.Libros");
        }
    }
}
