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
        ? $"images/noimage.png"// luego cambiamos esta url por la de //Azure
        : $"https://tiendaonlinedemo1.blob.core.windows.net/categories/{ImageId}"; // blob en Azure
      }
}
