using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Application.ViewModels
{
    public class ClienteUpdateViewModel
    {
        
        public Guid Id { get; set; }
        public Guid TelefoneId { get; set; }
        public Guid EnderecoId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "Digite seu CPF sem o uso de '.' ou '-'", MinimumLength = 11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(12, ErrorMessage = "Digite seu RG sem o uso de '.' ou '-'", MinimumLength = 12)]
        public string Rg { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }

        public IEnumerable<TelefoneViewModel> Telefones { get; set; }
        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }

    }
}
