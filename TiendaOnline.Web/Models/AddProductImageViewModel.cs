using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Models
{
      public class AddProductImageViewModel
      {
            public int ProductId { get; set; }

            [Display(Name = "Image")]
            [Required]
            public IFormFile ImageFile { get; set; }
      }

}
