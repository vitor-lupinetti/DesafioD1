using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio.D1.Application.ViewModels
{
    public class TelefoneViewModel
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "Digite seu número incluindo o DDD", MinimumLength = 10)]
        public string Numero { get; set; }

        [Display(Name = "Identificação (Ex: Comercial, Residencial, etc)")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Identificacao { get; set; }
    }
}
