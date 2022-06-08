using LiteDB;
using Microsoft.Extensions.Configuration;
using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Data
{
    public class LiteDbConnectionFactory
    {
        private readonly IConfiguration Configuration;
        public LiteDbConnectionFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var db = new LiteDatabase(@"C:\Temp\MyData.db");

                if (db == null)
                    return null;

                return (IDbConnection)db;
            }

        }
    }
}
