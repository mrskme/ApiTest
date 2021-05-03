using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTest.Model;
using Dapper;

namespace ApiTest
{
    public class MissionRepository
    {
        public async Task<IEnumerable<Mission>> GetAll()
        {
            var connection = ConnectionFactory.Create();
            var sql = "SELECT * FROM missions";
            return await connection.QueryAsync<Mission>(sql);
        }
    }
}
