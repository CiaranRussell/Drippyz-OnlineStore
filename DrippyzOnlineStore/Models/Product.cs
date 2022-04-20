using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrippyzOnlineStore.Models
{
    public class Product
    {
        [Key]
        [RegularExpression(@"^[A-Z''-'\s]{3,3}[\d]{3,3}$",
         ErrorMessage = "Product code format is strictly 'AAA999'")]
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [DisplayName("Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Price is required")]
        [DisplayName("Price (€)")]
        public double ProductPrice { get; set; }

        [DisplayName("Description")]
        [MaxLength(140, ErrorMessage = "Description must not contain more than 140 characters")]
        public string ProductDescription { get; set; }

        [DisplayName("Available")]
        public bool IsAvailable { get; set; }

        [DisplayName("Brand Name")]
        public int BrandNameID { get; set; }

        [ForeignKey("Brand-ID")]
        public BrandNames BrandID { get; set; }

        [DisplayName("Special Tag")]
        public int SpecialTagID { get; set; }

        [ForeignKey("SpecialTag-ID")]
        public SpecialTag SpecialTag { get; set; }
        
    }
}
