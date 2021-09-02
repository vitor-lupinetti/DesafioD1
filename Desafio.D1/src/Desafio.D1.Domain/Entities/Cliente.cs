using System;
using System.Collections.Generic;

#nullable disable

namespace Desafio.D1.Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClientesEnderecos = new HashSet<ClientesEndereco>();
            ClientesTelefones = new HashSet<ClientesTelefone>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }

        public virtual ICollection<ClientesEndereco> ClientesEnderecos { get; set; }
        public virtual ICollection<ClientesTelefone> ClientesTelefones { get; set; }
    }
}
