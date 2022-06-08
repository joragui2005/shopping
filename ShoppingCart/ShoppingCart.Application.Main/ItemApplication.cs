using ShoppingCart.Application.Dto;
using ShoppingCart.Application.Interface;
using ShoppingCart.Domain.Entity;
using ShoppingCart.Domain.Interface;
using ShoppingCart.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Main
{
    public class ItemApplication : IItemApplication
    {
        private readonly IItemRepository? _itemRepository;

        public ItemApplication(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Response<ItemEntity>> AddAsync(ItemEntity item)
        {
            try
            {
                var result = await _itemRepository.AddAsync(item);

                return ResponseState<ItemEntity>.OK("Item Added", result);
            }
            catch (Exception ex)
            {
                return ResponseState<ItemEntity>.InternalServerError(ex.Message);
            }
        }

        public async Task<Response<int>> DeleteAsync(int id)
        {
            try
            {
                var result = await _itemRepository.DeleteAsync(id);

                return ResponseState<int>.OK("Item deleted", result);
            }
            catch (Exception ex)
            {
                return ResponseState<int>.InternalServerError(ex.Message);
            }
        }

        public async Task<Response<IEnumerable<ItemEntity>>> GetAllAsync()
        {
            try
            {
                var result = await _itemRepository.GetAllAsync();

                return ResponseState<IEnumerable<ItemEntity>>.OK("Get all items", result, result.Count());
            }
            catch (Exception ex)
            {
                return ResponseState<IEnumerable<ItemEntity>>.InternalServerError(ex.Message);
            }
        }

        public async Task<Response<ItemEntity>> GetAsync(int id)
        {
            try
            {
                var result = await _itemRepository.GetAsync(id);

                return ResponseState<ItemEntity>.OK("Get item", result);
            }
            catch (Exception ex)
            {
                return ResponseState<ItemEntity>.InternalServerError(ex.Message);
            }
        }

        public async Task<Response<int>> UpdateAsync(int id, ItemEntity item)
        {
            try
            {
                var result = await _itemRepository.UpdateAsync(id, item);

                return ResponseState<int>.OK("Item updated", result);
            }
            catch (Exception ex)
            {
                return ResponseState<int>.InternalServerError(ex.Message);
            }
        }
    }
}
