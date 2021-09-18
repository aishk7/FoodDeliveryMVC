using FoodDeliveryMVC.Models;
using FoodDeliveryMVC.Services.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ShoppingCart _cart;
        private IItemRepo _itemRepo;
        private readonly FoodDBContext _foodDBContext;
        public HomeController(IItemRepo itemRepo, SignInManager<IdentityUser> signInManager, ShoppingCart cart, FoodDBContext foodDBContext)
        {
            _itemRepo = itemRepo;
            _cart = cart;
            _signInManager = signInManager;
            _foodDBContext = foodDBContext;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Verify()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return Redirect("Identity/Account/Login");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
                _cart.ClearCart();
                return Redirect($"/Identity/Account/Login");
            }
            return BadRequest("User not logged in");
        }

        [Authorize]
        public IActionResult Speciality()
        {
            var model = _itemRepo.IsSpecial();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SearchFood(string SearchItem)
        {
            if(SearchItem==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var items = _foodDBContext.Items.Where(x => x.ItemName.Contains(SearchItem));
                return View(items);
            }

        }

        [Authorize]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
