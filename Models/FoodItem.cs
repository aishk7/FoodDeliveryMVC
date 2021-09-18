using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Models
{
    public class FoodItem
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public string Details { get; set; }
        public string ImgURL { get; set; }
        public Boolean IsSpecial { get; set; }
        public FoodCategory category { get; set; }
        public int CategoryId { get; set; }
        
    }
}
