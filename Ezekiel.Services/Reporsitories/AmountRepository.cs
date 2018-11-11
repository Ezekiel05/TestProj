using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ezekiel.Services.ViewModels;
using System.Data;
using System.Data.SqlClient;

namespace Ezekiel.Services.Reporsitories
{
    public class AmountRepository : IAmountRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Ezekiel-DB"].ConnectionString;

        public IList<AmountLog> GetAllAmountLog()
        {
            IList<AmountLog> result;
            string query = @"SELECT * FROM [Ezekiel].[dbo].[AmountLog]";

            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                result = db.Query<AmountLog>(query, null).ToList();
            }
            return result;
        }

        public IList<AmountLog> LogAmount(DateTime dateTime, int amount, string messageLog, DateTime date)
        {
            IList<AmountLog> result;
            string query = @"INSERT INTO Ezekiel.dbo.AmountLog ([DateTime],Amount,MessageLog,[Date])
                             VALUES (@dateTime, @amount, @messageLog, @date)
                             SELECT * FROM [Ezekiel].[dbo].[AmountLog]
                             WHERE [DateTime] = @dateTime AND Amount = @amount";

            object parameters = new
            {
                dateTime,
                amount,
                messageLog,
                date
            };

            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                result = db.Query<AmountLog>(query, parameters).ToList();
            }
            return result;
        }
    }
}
