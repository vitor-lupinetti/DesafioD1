using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;

namespace Desafio.D1.Infra.Data.Repository
{
    public class TelefoneRepository: Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(DesafioD1Context context):base(context)
        {
        }
    }
}
