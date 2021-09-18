using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        
        [Required(ErrorMessage = "Please enter your first name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "No numbers or special characters allowed")]
        [Display(Name = "First Name")]
        [StringLength(15)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "No numbers or special characters allowed")]
        [Display(Name = "Last Name")]
        [StringLength(15)]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please enter your Address")]
        [StringLength(200)]
        [Display(Name = "Address")]
        public string LandMark { get; set; }
        
        [Required(ErrorMessage = "Please enter your Pincode")]
        [StringLength(6, MinimumLength = 6, ErrorMessage ="Specify Pincode of 6 digits")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Only numbers allowed")]
        [Display(Name = "Pin code")]
        public string Pincode { get; set; }
        
        [Required(ErrorMessage = "Please enter your City")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "No numbers or special characters allowed")]
        [StringLength(20)]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Please enter your State")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "No numbers or special characters allowed")]
        public string State { get; set; }
        
        [Required(ErrorMessage = "Please enter your Country")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "No numbers or special characters allowed")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your Phone number without '0' as prefix.")]
        [StringLength(10, MinimumLength =10)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Only numbers allowed")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter your Email ")]
        [StringLength(25)]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
    }
}
