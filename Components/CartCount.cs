using FoodDeliveryMVC.Models;
using FoodDeliveryMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Components
{
    public class CartCount: ViewComponent
    {
        ShoppingCart _shoppingCart;
        public CartCount(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }


        public IViewComponentResult Invoke()
        {
            var model = _shoppingCart.GetShoppingItems().ToList();
            var tot = 0;
            foreach(var item in model)
            {
                tot += item.Quantity;
            }
            return View(new DynamicCart { TotalCnt = tot});
        }
    }
}
