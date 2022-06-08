using ShoppingCart.Domain.Entity;
using ShoppingCart.Domain.Interface;
using ShoppingCart.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Interface
{
    public interface IItemApplication
    {
        Task<Response<IEnumerable<ItemEntity>>> GetAllAsync();
        Task<Response<ItemEntity>> GetAsync(int id);
        Task<Response<int>> DeleteAsync(int id);
        Task<Response<ItemEntity>> AddAsync(ItemEntity item);
        Task<Response<int>> UpdateAsync(int id, ItemEntity item);
    }
}
