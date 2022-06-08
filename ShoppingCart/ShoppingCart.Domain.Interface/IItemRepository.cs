using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interface
{
    public interface IItemRepository
    {
        Task<IEnumerable<ItemEntity>> GetAllAsync();
        Task<ItemEntity> GetAsync(int id);
        Task<int> DeleteAsync(int id);
        Task<ItemEntity> AddAsync(ItemEntity item);
        Task<int> UpdateAsync(int id, ItemEntity item);

    }
}
