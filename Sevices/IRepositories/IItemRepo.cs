using FoodDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Services.IRepositories
{
    public interface IItemRepo
    {
        IEnumerable<FoodItem> DisplayWithinCat(string name);
        public IEnumerable<FoodItem> IsSpecial();
        public FoodItem GetItemWithId(int id);
    }
}
