using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DrippyzOnlineStore.Models
{
    public class SpecialTag
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Special Tag Name is required")]
        [DisplayName("Brand Name")]
        public string Name { get; set; }
    }
}
