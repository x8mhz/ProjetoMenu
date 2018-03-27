using ProjetoMenu.Model.Data.EntityConfig;
using ProjetoMenu.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoMenu.Model.Data.Context
{
    public class ProjectMenuContext : DbContext
    {
        public ProjectMenuContext() : base ("Context")
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Configurations.Add(new ProductMap()); 
        }
    }
}
