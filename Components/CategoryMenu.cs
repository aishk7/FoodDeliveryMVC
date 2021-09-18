using FoodDeliveryMVC.Services.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Components
{
    public class CategoryMenu : ViewComponent 
    {
        private ICategoryRepo _categoryRepo;
        //DI
        public CategoryMenu(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;

        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepo.DisplayAllCategory(); //.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
