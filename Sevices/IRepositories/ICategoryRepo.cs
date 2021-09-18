using FoodDeliveryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Services.IRepositories
{
    public interface ICategoryRepo
    {
        IEnumerable<FoodCategory> DisplayAllCategory();
        IEnumerable<FoodItem> viewByCat(string s);
    }
}
