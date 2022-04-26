using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaOnline.Web.Data;
using TiendaOnline.Web.Models;
public class SeedDb
{
    private readonly ApplicationDbContext _context;
    public SeedDb(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckCountriesAsync();
    }
    private async Task CheckCountriesAsync()
    {
        if (!_context.Countries.Any())
        {
            _context.Countries.Add(new Country
            {
                Name = "Colombia",
                Departments = new List<Department>
                 {
                     new Department
                     {
                        Name = "Antioquia",
                        Cities = new List<City>
                        {
                             new City { Name = "Medellín" },
                             new City { Name = "Envigado" },
                             new City { Name = "Itagüí" }
                        }
                     },
                     new Department
                     {
                         Name = "Cundinamarca",
                         Cities = new List<City>
                         {
                             new City { Name = "Bogotá" }
                          }
                      },
                     new Department
                     {
                         Name = "Nariño",
                         Cities = new List<City>
                         {
                              new City { Name = "Pasto" },
                                 new City { Name = "Ipiales" },
                                 new City { Name = "Pupiales" }
                          }

                      }

                 }
            });
            _context.Countries.Add(new Country
            {
                Name = "Argentina",
                Departments = new List<Department>
                {
                    new Department
                    {
                         Name = "Buenos Aires",
                         Cities = new List<City>
                          {
                             new City { Name = "Mar Del Plata" },
                             new City { Name = "Quilmes" },
                             new City { Name = "Lanús" }
                         }
                    },
                    new Department
                     {
                         Name = "Mendoza",
                         Cities = new List<City>
                        {
                         new City { Name = "Godoy Cruz" },
                         new City { Name = "Las Heras" }
                        }
                    }
                }
            });
            await _context.SaveChangesAsync();
        }

    }
}
