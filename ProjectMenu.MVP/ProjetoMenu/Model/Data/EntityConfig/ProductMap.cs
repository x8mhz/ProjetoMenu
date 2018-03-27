using ProjetoMenu.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMenu.Model.Data.EntityConfig
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Produtos");

            HasKey(p => p.Id);
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Code)
                .HasColumnName("Codigo")
                .IsRequired();

            Property(p => p.Brand)
                .HasColumnName("Marca")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Model)
                .HasColumnName("Modelo")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Description)
                .HasColumnName("Descricao")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Amount)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(p => p.Price)
                .HasColumnName("Valor")
                .IsRequired();
        }
    }
}
