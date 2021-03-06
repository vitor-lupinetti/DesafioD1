using Dapper;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly DesafioD1Context _context;
        public ClienteRepository(DesafioD1Context context) : base(context)
        {
            _context = context;
        }

        
        public override async Task<Cliente> GetById(System.Guid id)
        {
            var cn = _context.Database.GetDbConnection();
            var sql = @"SELECT c.*, e.Id as EnderecoId, e.Rua, e.Bairro, e.Cep, e.Numero, t.Id as TelefoneId, t.Identificacao, t.Numero as NumeroTel from Clientes c 
                        join Clientes_Enderecos ce on c.Id = ce.IdCliente
                        join Enderecos e on ce.IdEndereco = e.Id
                        join Clientes_Telefones ct on ct.IdCliente = c.Id
                        join Telefones t on ct.IdTelefone = t.Id 
                        where c.Id = @sid";
                        


            var clientes = await cn.QueryAsync<Cliente>(sql , new { sid = id });

            return clientes.AsList()[0];
        }

        public IEnumerable<Cliente> ObterPorNome(string nome)
        {
            var clientes =  GetWhere(c => c.Nome == nome);
            return clientes;
        }
    }
}
