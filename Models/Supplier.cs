
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnails.Models
{
    public class Supplier
    {
        
        public int ID { get; set; }
        
        [StringLength(25, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Location { get; set; }
        
        public int Contact { get; set; }
        
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string SupplierGrading { get; set; }
        
        [StringLength(50, MinimumLength = 0)]
        [Required]
        public string Comments { get; set; }
    }
}