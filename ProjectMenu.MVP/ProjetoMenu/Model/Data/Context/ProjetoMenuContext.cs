using ProjetoMenu.Model.Data.EntityConfig;
using ProjetoMenu.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoMenu.Model.Data.Context
{
    public class ProjetoMenuContext : DbContext
    {
        public ProjetoMenuContext() : base ("Context")
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ProdutoMap());
 
        }
    }
}
