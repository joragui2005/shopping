using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interface
{
    public interface ICartingRepository
    {
        Task<CartingEntity> GetAsync(int id);
        Task<ItemEntity> AddItemAsync(ItemEntity item, int id);
        Task<int> RemoveItemAsync(int idItem, int id);
    }
}
