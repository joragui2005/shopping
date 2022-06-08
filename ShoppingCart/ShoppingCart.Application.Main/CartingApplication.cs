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
    public class CartingApplication : ICartingApplication
    {
        private readonly ICartingRepository _cartingRepository;

        public CartingApplication(ICartingRepository cartingRepository)
        {
            _cartingRepository = cartingRepository;
        }

        public async Task<Response<ItemEntity>> AddItemAsync(ItemEntity item, int id)
        {
            try
            {
                var result = await _cartingRepository.AddItemAsync(item, id);

                return ResponseState<ItemEntity>.OK("Item added", result);
            }
            catch (Exception ex)
            {
                return ResponseState<ItemEntity>.InternalServerError(ex.Message);
            }
        }

        public async Task<Response<CartingEntity>> GetAsync(int id)
        {
            try
            {
                var result = await _cartingRepository.GetAsync(id);

                return ResponseState<CartingEntity>.OK("Get item", result);
            }
            catch (Exception ex)
            {
                return ResponseState<CartingEntity>.InternalServerError(ex.Message);
            }
        }

        public async Task<Response<int>> RemoveItemAsync(int idItem, int id)
        {
            try
            {
                var result = await _cartingRepository.RemoveItemAsync(idItem, id);

                return ResponseState<int>.OK("Item removed", result);
            }
            catch (Exception ex)
            {
                return ResponseState<int>.InternalServerError(ex.Message);
            }
        }
    }
}
