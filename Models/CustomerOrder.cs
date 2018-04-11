using System;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnails.Models
{
    public class CustomerOrder
    {
        public int ID { get; set; }
        
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Location { get; set; }
        
        [Display(Name = "Delivery Date")]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        
        public int Quantity { get; set; }
        
        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Delivery Status")]
        [Required]
        public string DeliveryStatus { get; set; }
        
        [StringLength(100, MinimumLength = 0)]
        public string Comments { get; set; }
    }
}