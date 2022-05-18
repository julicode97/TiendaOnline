using Microsoft.AspNetCore.Mvc.Rendering;
using TiendaOnline.Web.Data;

namespace TiendaOnline.Web.Helpers
{
      public class CombosHelper : ICombosHelper
      {
            private readonly ApplicationDbContext _context;

            public CombosHelper(ApplicationDbContext context)
            {
                  _context = context;
            }

            public IEnumerable<SelectListItem> GetComboCategories()
            {
                  List<SelectListItem> list = _context.Categories.Select(t => new SelectListItem
                  {
                        Text = t.Name,
                        Value = $"{t.Id}"
                  })
                      .OrderBy(t => t.Text)
                      .ToList();

                  list.Insert(0, new SelectListItem
                  {
                        Text = "[Select a category...]",
                        Value = "0"
                  });

                  return list;
            }
      }

}
