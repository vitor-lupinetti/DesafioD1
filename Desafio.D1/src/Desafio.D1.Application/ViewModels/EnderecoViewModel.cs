using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public Guid Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public Guid ClienteId { get; set; }

    }
}
