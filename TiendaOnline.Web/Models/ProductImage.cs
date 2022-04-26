using System;
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        [Display(Name = "Image")]
        public Guid ImageId { get; set; }
        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
        ? $"https://localhost:44390/images/noimage.png"
        : $"https://Tiendaonline.Web.blob.core.windows.net/products/{ImageId}";
    }
}
