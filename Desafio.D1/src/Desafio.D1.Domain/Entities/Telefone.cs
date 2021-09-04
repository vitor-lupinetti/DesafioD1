using System;
using System.Collections.Generic;

#nullable disable

namespace Desafio.D1.Domain.Entities
{
    public partial class Telefone
    {
        public Telefone()
        {
            ClientesTelefones = new HashSet<ClientesTelefone>();
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Identificacao { get; set; }

        public virtual ICollection<ClientesTelefone> ClientesTelefones { get; set; }
    }
}
