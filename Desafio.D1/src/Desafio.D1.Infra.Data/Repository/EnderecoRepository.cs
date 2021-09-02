using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;

namespace Desafio.D1.Infra.Data.Repository
{
    public class EnderecoRepository: Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DesafioD1Context context):base(context)
        {
        }
    }
}
