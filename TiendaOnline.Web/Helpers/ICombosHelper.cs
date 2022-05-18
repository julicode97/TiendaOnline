using Microsoft.AspNetCore.Mvc.Rendering;

namespace TiendaOnline.Web.Helpers
{
      public interface ICombosHelper
      {
            IEnumerable<SelectListItem> GetComboCategories();
      }
}
