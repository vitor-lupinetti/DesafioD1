using System;

#nullable disable

namespace Desafio.D1.Domain.Entities
{
    public partial class ClientesEndereco
    {
        public Guid Id { get; set; }
        public int IdCliente { get; set; }
        public Guid IdEndereco { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Endereco IdEnderecoNavigation { get; set; }
    }
}
