using ProjetoMenu.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMenu.Model.Data.EntityConfig
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {

            ToTable("Produtos");

            HasKey(p => p.Id);
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Marca)
                .HasColumnName("Marca")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Tipo)
                .HasColumnName("Descricao")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Modelo)
                .HasColumnName("Modelo")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Quantidade)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(p => p.Valor)
                .HasColumnName("Valor_Unitario")
                .IsRequired();

        }
    }
}
