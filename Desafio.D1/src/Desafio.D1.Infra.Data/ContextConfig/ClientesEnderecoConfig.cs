using Desafio.D1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.D1.Infra.Data.ContextConfig
{
    public class ClientesEnderecoConfig : IEntityTypeConfiguration<ClientesEndereco>
    {
        public void Configure(EntityTypeBuilder<ClientesEndereco> entity)
        {
            entity.ToTable("Clientes_Enderecos");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.ClientesEnderecos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientes_enderecos_fk");

            entity.HasOne(d => d.IdEnderecoNavigation)
                .WithMany(p => p.ClientesEnderecos)
                .HasForeignKey(d => d.IdEndereco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("enderecos_clientes_fk");
        }
    }
}
