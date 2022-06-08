using Microsoft.Extensions.Configuration;
using ShoppingCart.Transversal.Common;
using System.Data;
using System.Data.SqlClient;

namespace ShoppingCart.Domain.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration Configuration;
        public ConnectionFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null)
                    return null;

                sqlConnection.ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];
                sqlConnection.Open();

                return sqlConnection;
            }

        }
    }
}
