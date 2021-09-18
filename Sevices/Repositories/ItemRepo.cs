using FoodDeliveryMVC.Models;
using FoodDeliveryMVC.Services.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Services.Repositories
{
    public class ItemRepo : IItemRepo
    {
        FoodDBContext _context;
        public ItemRepo(FoodDBContext context)
        {
            _context = context;
        }
        public ItemRepo()
        {
            
        }

        public IEnumerable<FoodItem> DisplayWithinCat(string name)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<FoodItem> IsSpecial()
        {
            var special = _context.Items.Where(x => x.IsSpecial == true);
            return special;
        }
        public FoodItem GetItemWithId(int id)
        {
            var tmp = _context.Items.FirstOrDefault(x => x.ItemId == id);
            return tmp;
        }
    }
}
