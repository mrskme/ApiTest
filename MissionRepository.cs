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

        public async Task<IEnumerable<int>> Create(Mission mission)
        {
            var connection = ConnectionFactory.Create();
            var sql = "INSERT INTO missions (title, text) VALUES (@Title, @Text)";
            return await connection.QueryAsync<int>(sql, mission);
        }
    }
}
