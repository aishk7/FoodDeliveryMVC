using FoodDeliveryMVC.Models;
using FoodDeliveryMVC.Services.IRepositories;
using FoodDeliveryMVC.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyDemo.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IItemRepo _items;

        public CartController(IItemRepo itemsRepo, ShoppingCart shoppingCart)
        {
            _items = itemsRepo;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index(int ItemId)
        {
            var items = _shoppingCart.GetShoppingItems().ToList();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetTotal()
            };
            return View(shoppingCartViewModel);
        }
        public IActionResult AddToCart(int ItemId)
        {
            var item = _items.GetItemWithId(ItemId);
            if (item != null)
            {
                _shoppingCart.AddToCart(item);
            }
            return RedirectToAction("Index");
            //return RedirectToAction("Index", "Home"); //Action, Controller
        }
        public IActionResult RemoveFromCart(int ItemId)
        {
            var item = _items.GetItemWithId(ItemId);
            if (item != null)
            {
                _shoppingCart.RemoveFromcart(item);
            }
            return RedirectToAction("Index");
        }
        public IActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}