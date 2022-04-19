using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DrippyzOnlineStore.Models
{
    public class BrandNames
    {
        [Key]
        [DisplayName("Brand ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Brand Name is required")]
        [DisplayName("Brand Name")]
        public string Brand { get; set; }
    }
}
