using Desafio.D1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.D1.Infra.Data.ContextConfig
{
    public class TelefoneConfig : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> entity)
        {

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Identificacao)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}
