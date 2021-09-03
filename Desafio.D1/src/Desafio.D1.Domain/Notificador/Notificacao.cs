using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.D1.Domain.Notificador
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }
    }
}
