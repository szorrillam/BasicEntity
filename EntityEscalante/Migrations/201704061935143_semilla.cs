namespace EntityEscalante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semilla : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Escritores(Nombre, Pais) Values('Samuel Escalante', 'República Dominicana')");
        }
        
        public override void Down()
        {
            Sql("Delete FROM Escritores");
        }
    }
}
