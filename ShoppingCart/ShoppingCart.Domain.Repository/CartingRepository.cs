using Dapper;
using ShoppingCart.Domain.Entity;
using ShoppingCart.Domain.Interface;
using ShoppingCart.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Repository
{
    public class CartingRepository : ICartingRepository
    {
        private readonly IConnectionFactory _sqlConnection;

        public CartingRepository(IConnectionFactory sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public async Task<ItemEntity> AddItemAsync(ItemEntity item, int id)
        {
            using var conn = _sqlConnection.GetConnection;
            var query = "CartAddItem";
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            parameters.Add("name", item.Name);
            parameters.Add("price", item.Price);
            parameters.Add("quantity", item.Quantity);
            parameters.Add("image", item.Image);
            parameters.Add("item_id", item.Id);

            var result = await conn.QueryAsync<ItemEntity>(query, parameters, commandType: System.Data.CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public async Task<CartingEntity> GetAsync(int id)
        {
            using var conn = _sqlConnection.GetConnection;
            var query = "GetCart";
            var cart = await conn.QueryAsync<CartingEntity>(query, commandType: System.Data.CommandType.StoredProcedure);

            return cart.FirstOrDefault();
        }

        public async Task<int> RemoveItemAsync(int itemId, int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id);
            parameters.Add("item_id", itemId);
            using var conn = _sqlConnection.GetConnection;
            var query = "DeleteItem";

            var rowAffected = await conn.ExecuteAsync(query, parameters, commandType: System.Data.CommandType.StoredProcedure);

            return rowAffected;
        }
    }
}
