using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio.D1.Application.ViewModels
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        [Display(Name ="Data de nascimento")]
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

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cep { get; set; }

        [Display(Name = "Número residencial")]

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Numero { get; set; }

        [Display(Name = "Número do telefone")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "Digite seu número incluindo o DDD", MinimumLength = 10)]
        public string NumeroTel { get; set; }


        [Display(Name = "Identificação (Ex: Comercial, Residencial, etc)")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Identificacao { get; set; }
    }
}
