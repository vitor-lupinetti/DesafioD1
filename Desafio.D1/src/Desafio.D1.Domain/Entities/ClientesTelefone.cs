using System;

#nullable disable

namespace Desafio.D1.Domain.Entities
{
    public partial class ClientesTelefone
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdTelefone { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Telefone IdTelefoneNavigation { get; set; }
    }
}
