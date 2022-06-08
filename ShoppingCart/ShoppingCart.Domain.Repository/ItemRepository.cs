using ShoppingCart.Domain.Entity;
using ShoppingCart.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly IItemRepository _itemRepository;
        public ItemRepository(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<ItemEntity> AddAsync(ItemEntity item)
        {
            var itemRepository = await _itemRepository.AddAsync(item);

            return itemRepository;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var rowsAffected = await _itemRepository.DeleteAsync(id);

            return rowsAffected;
        }

        public async Task<IEnumerable<ItemEntity>> GetAllAsync()
        {
            var items = await _itemRepository.GetAllAsync();
            
            return items;
        }

        public async Task<ItemEntity> GetAsync(int id)
        {
            var item = await _itemRepository.GetAsync(id);

            return item;
        }

        public async Task<int> UpdateAsync(int id, ItemEntity item)
        {
            var rowAffected = await _itemRepository.UpdateAsync(id, item);

            return rowAffected;
        }
    }
}
