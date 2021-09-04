using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Application.ViewModels
{
    public class ClienteUpdateViewModel
    {
        public ClienteUpdateViewModel()
        {
        }
        public Guid Id { get; set; }
        public Guid TelefoneId { get; set; }
        public Guid EnderecoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }

        public IEnumerable<TelefoneViewModel> Telefones { get; set; }
        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }


        //    public string Rua { get; set; }
        //    public string Bairro { get; set; }
        //    public string Cep { get; set; }
        //    public int Numero { get; set; }
        //    public string NumeroTelefone { get; set; }
        //    public string Identificacao { get; set; }
    }
}
