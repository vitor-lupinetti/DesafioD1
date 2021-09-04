using System;

namespace Desafio.D1.Application.ViewModels
{
    public class TelefoneViewModel
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public string Numero { get; set; }
        public string Identificacao { get; set; }
    }
}
