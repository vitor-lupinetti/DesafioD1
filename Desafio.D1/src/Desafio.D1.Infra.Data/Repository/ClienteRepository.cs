using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;

namespace Desafio.D1.Infra.Data.Repository
{
    public class ClienteRepository: Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DesafioD1Context context) : base(context) { }
       
    }
}
