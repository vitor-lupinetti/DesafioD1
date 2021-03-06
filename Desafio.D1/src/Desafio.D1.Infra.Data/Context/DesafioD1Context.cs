using System;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Infra.Data.ContextConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Desafio.D1.Infra.Data
{
    public partial class DesafioD1Context : DbContext
    {
        private readonly IConfiguration _configuration;
        public DesafioD1Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DesafioD1Context(DbContextOptions<DesafioD1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientesEndereco> ClientesEnderecos { get; set; }
        public virtual DbSet<ClientesTelefone> ClientesTelefones { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetSection("ConnectionString").Value);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.ApplyConfiguration(new ClienteConfig());

            modelBuilder.ApplyConfiguration(new ClientesEnderecoConfig());

            modelBuilder.ApplyConfiguration(new ClientesTelefoneConfig());

            modelBuilder.ApplyConfiguration(new EnderecoConfig());

            modelBuilder.ApplyConfiguration(new TelefoneConfig());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
