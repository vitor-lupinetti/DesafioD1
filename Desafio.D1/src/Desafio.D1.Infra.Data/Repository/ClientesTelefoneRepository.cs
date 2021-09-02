using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;

namespace Desafio.D1.Infra.Data.Repository
{
    public class ClientesTelefoneRepository: Repository<ClientesTelefone>, IClientesTelefoneRepository
    {
        public ClientesTelefoneRepository(DesafioD1Context context):base(context)
        {
        }
    }
}
