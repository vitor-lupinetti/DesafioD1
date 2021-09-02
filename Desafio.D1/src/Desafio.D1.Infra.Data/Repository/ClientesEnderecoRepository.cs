using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;

namespace Desafio.D1.Infra.Data.Repository
{
    public class ClientesEnderecoRepository: Repository<ClientesEndereco>, IClientesEnderecoRepository
    {
        public ClientesEnderecoRepository(DesafioD1Context context): base(context)
        {
        }
    }
}
