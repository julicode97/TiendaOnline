using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Models
{
    public class CategoryViewModel : Category
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
