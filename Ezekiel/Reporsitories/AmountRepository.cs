using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Ezekiel.ViewModels;
using System.Data;
using System.Data.SqlClient;

namespace Ezekiel.Reporsitories
{
    public class AmountRepository : IAmountRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Ezekiel-DB"].ConnectionString;

        public IList<AmountLog> GetAllAmountLog()
        {
            IList<AmountLog> result = null;
            string query = @"Select * from dbo.AmountLog";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                result = db.Query<AmountLog>(query).ToList();
            }
            return result;
        }
    }
}
