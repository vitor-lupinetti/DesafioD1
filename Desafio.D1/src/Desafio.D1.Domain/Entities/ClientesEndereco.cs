using System;

#nullable disable

namespace Desafio.D1.Domain.Entities
{
    public partial class ClientesEndereco
    {
        public ClientesEndereco()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdEndereco { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Endereco IdEnderecoNavigation { get; set; }
    }
}
