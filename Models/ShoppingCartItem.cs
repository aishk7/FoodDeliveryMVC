using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemid { get; set; }
        public int ItemRef { get; set; }
        public FoodItem Item { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
