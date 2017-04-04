using ProjetoModeloTDD.Domain.Entites;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloTDD.Data.EntityConfig
{
   public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
   {

        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
                
        }
   }
}
