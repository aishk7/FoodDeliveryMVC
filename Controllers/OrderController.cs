using FoodDeliveryMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly FoodDBContext _context;
        private readonly ShoppingCart _cart;
        public OrderController(FoodDBContext context, ShoppingCart cart)
        {
            _cart = cart;
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                _cart.ClearCart();
                return RedirectToAction("TransComplete");
            }
            return View();
        }
        
        public IActionResult TransComplete()
        {
            return View();
        }
    }
}
