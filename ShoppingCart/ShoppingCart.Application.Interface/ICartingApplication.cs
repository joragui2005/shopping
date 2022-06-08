using ShoppingCart.Domain.Entity;
using ShoppingCart.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Interface
{
    public interface ICartingApplication
    {
        Task<Response<CartingEntity>> GetAsync(int id);
        Task<Response<ItemEntity>> AddItemAsync(ItemEntity item, int id);
        Task<Response<int>> RemoveItemAsync(int idItem, int id);
    }
}
