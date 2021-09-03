using Desafio.D1.Domain.Notificador;
using System.Collections.Generic;

namespace Desafio.D1.Domain.Interfaces.Services
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
