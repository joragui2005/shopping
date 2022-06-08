using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entity
{
    public class CartingEntity
    {
        public int Id { get; set; }
        public List<ItemEntity> Items { get; set; }
    }
}
