using System;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Helpers
{
      public interface IConverterHelper
      {
            Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew);

            CategoryViewModel ToCategoryViewModel(Category category);
            Task<Product> ToProductAsync(ProductViewModel model, bool isNew);

            ProductViewModel ToProductViewModel(Product product);

      }

}
