using Desafio.D1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.D1.Infra.Data.ContextConfig
{
    public class ClientesTelefoneConfig : IEntityTypeConfiguration<ClientesTelefone>
    {
        public void Configure(EntityTypeBuilder<ClientesTelefone> entity)
        {
            entity.ToTable("Clientes_Telefones");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.ClientesTelefones)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_telefones_fk");

            entity.HasOne(d => d.IdTelefoneNavigation)
                .WithMany(p => p.ClientesTelefones)
                .HasForeignKey(d => d.IdTelefone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("telefone_clientes_fk");
        }
    }
}
