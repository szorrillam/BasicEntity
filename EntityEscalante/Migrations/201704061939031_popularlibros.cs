namespace EntityEscalante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popularlibros : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Libros(Nombre, ISBN, EscritorId)VALUES('Marisol en el país de las maravillas', '1525412-524-52', 1)");
            Sql("INSERT INTO Libros(Nombre, ISBN, EscritorId)VALUES('Dynamics: La historia de nunca acabar', '1525412-524-53', 1)");
            Sql("INSERT INTO Libros(Nombre, ISBN, EscritorId)VALUES('Dynamics: Los usuarios se revelan', '1525412-524-54', 1)");
            Sql("INSERT INTO Libros(Nombre, ISBN, EscritorId)VALUES('Dynamics: Resurrección', '1525412-524-55', 1)");
            Sql("INSERT INTO Libros(Nombre, ISBN, EscritorId)VALUES('SharePoint: Un nuevo comienzo', '1525412-524-56', 1)");

        }

        public override void Down()
        {
            Sql("DELETE FROM Libros");
        }
    }
}
