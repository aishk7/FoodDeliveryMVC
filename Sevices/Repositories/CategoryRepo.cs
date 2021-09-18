using FoodDeliveryMVC.Models;
using FoodDeliveryMVC.Services.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Services.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        FoodDBContext _context;
        public CategoryRepo(FoodDBContext context)
        {
            _context = context;
        }
        public CategoryRepo()
        {
            
        }
        public IEnumerable<FoodCategory> DisplayAllCategory()
        {
            return _context.Categories.OrderBy(x => x.CategoryName);
        }
        public IEnumerable<FoodItem> viewByCat(string cat)
        {
            var id = _context.Categories.Where(x => x.CategoryName == cat).Select(x => x.CategoryId).FirstOrDefault();
            return _context.Items.Where(x => x.CategoryId == id);
        }

    }
}
