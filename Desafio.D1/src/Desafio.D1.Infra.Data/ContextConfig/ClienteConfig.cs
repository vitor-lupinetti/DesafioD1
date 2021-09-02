using Desafio.D1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Infra.Data.ContextConfig
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPF");

            entity.Property(e => e.DataNascimento).HasColumnType("datetime");

            entity.Property(e => e.Facebook).IsUnicode(false);

            entity.Property(e => e.Instagram).IsUnicode(false);

            entity.Property(e => e.Linkedin).IsUnicode(false);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Rg)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RG");

            entity.Property(e => e.Twitter).IsUnicode(false);

        }
    }
}
