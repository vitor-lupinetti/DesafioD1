using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }


        [NotMapped]
        public string Rua { get; set; }
        [NotMapped]

        public string Bairro { get; set; }
        [NotMapped]

        public string Cep { get; set; }
        [NotMapped]

        public int Numero { get; set; }
        [NotMapped]

        public string NumeroTel { get; set; }
        [NotMapped]

        public string Identificacao { get; set; }

        public virtual ICollection<ClientesEndereco> ClientesEnderecos { get; set; }
        public virtual Telefone Telefone { get; set; }
        public virtual ICollection<ClientesTelefone> ClientesTelefones { get; set; }
    }
}
