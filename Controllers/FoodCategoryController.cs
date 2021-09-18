using FoodDeliveryMVC.Services.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Controllers
{
    [Authorize]
    public class FoodCategoryController : Controller
    {
        private ICategoryRepo _categoryRepo;
        private IItemRepo _itemRepo;
        public FoodCategoryController(ICategoryRepo categoryRepo, IItemRepo itemRepo)
        {
            _categoryRepo = categoryRepo;
            _itemRepo = itemRepo;
        }
        public IActionResult Index()
        {
            var model = _categoryRepo.DisplayAllCategory();
            return View(model);
        }
        public IActionResult DisplayByCat(string cat)
        {
            var model = _categoryRepo.viewByCat(cat);
            return View(model);
        }
    }
}
