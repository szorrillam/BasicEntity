namespace EntityEscalante
{
    using EntityEscalante.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityEscalante.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Escritor> Escritores { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Escritor>()
                .ToTable("Escritores")
                .Property(x => x.Nombre)
                .HasMaxLength(100);
            modelBuilder.Entity<Escritor>()
                .Property(x => x.Pais)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Escritor>()
                .HasMany(x => x.Libros)
                .WithRequired(x => x.Escritor);

            modelBuilder.Entity<Libro>()
                .ToTable("Libros")
                .Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(200);
            modelBuilder.Entity<Libro>()
                .Property(x => x.ISBN)
                .IsRequired()
                .HasMaxLength(20);

            base.OnModelCreating(modelBuilder);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}