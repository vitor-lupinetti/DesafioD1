using Dapper;
using Desafio.D1.Domain.Entities;
using Desafio.D1.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.D1.Infra.Data.Repository
{
    public class TelefoneRepository: Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(DesafioD1Context context):base(context)
        {
        }

        public async Task<IEnumerable<Telefone>> GetPhonesByUserId(Guid id)
        {
            var cn = _context.Database.GetDbConnection();

            var sql = @"select * from Clientes_Telefones ct 
                        join Telefones t on ct.IdTelefone = t.Id 
                        where IdCliente = @sid";



            var telefones = await cn.QueryAsync<Telefone>(sql, new { sid = id });

            return telefones;
        }
    }
}
