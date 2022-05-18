﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TiendaOnline.Web.Models
{
      public class ProductViewModel : Product
      {
            [Display(Name = "Category")]
            [Range(1, int.MaxValue, ErrorMessage = "You must select a category.")]
            [Required]
            public int CategoryId { get; set; }

            public IEnumerable<SelectListItem> Categories { get; set; }

            [Display(Name = "Image")]
            public IFormFile ImageFile { get; set; }
      }
}
