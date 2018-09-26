using Microsoft.EntityFrameworkCore;
using MyWebApp.Entidades;

namespace MyWebApp
{
    public class MyWebAppContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Produto> Produtos{ get; set; }

        public MyWebAppContext(DbContextOptions<MyWebAppContext> options):base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasKey(p => p.Id);
            modelBuilder.Entity<Empresa>().HasKey(p => p.Id);
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);


        }

        public override int SaveChanges() {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
