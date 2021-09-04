using Dapper;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Infra.Data.Repository
{
    public class EnderecoRepository: Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DesafioD1Context context):base(context)
        {
        }

        public async Task<IEnumerable<Endereco>> GetAdressesByUserId(Guid id)
        {
            var cn = _context.Database.GetDbConnection();

            var sql = @"select * from Clientes_Enderecos ce 
                        join Enderecos e on ce.IdEndereco = e.Id
                        where IdCliente = @sid";

            var enderecos = await cn.QueryAsync<Endereco>(sql, new { sid = id });

            return enderecos;
        }
    }
}
