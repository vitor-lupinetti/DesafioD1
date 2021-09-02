using System;
using System.Collections.Generic;

#nullable disable

namespace Desafio.D1.Domain.Entities
{
    public partial class Endereco
    {
        public Endereco()
        {
            ClientesEnderecos = new HashSet<ClientesEndereco>();
        }

        public Guid Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }

        public virtual ICollection<ClientesEndereco> ClientesEnderecos { get; set; }
    }
}
