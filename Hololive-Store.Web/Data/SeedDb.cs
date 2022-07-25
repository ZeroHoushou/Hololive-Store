using Hololive_Store.Common.Entities;
using Hololive_Store.Web.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
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
                Name = "Perú",
                Departments = new List<Department>
                {
                    new Department
                    {
                        Name = "Lima",
                        Cities = new List<City>
                        {
                            new City { Name = "Lima" },
                            new City { Name = "Magdalena" },
                            new City { Name = "San Miguel" }
                        }
                    },
                    new Department
                    {
                        Name = "Callao",
                        Cities = new List<City>
                        {
                            new City { Name = "Ventanilla" },
                            new City { Name = "Mi Perú" },
                            new City {Name = "La Perla"}
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
                            new City { Name = "La Plata" },
                            new City { Name = "Las Flores" },
                            new City { Name = "Lomas de Zamora" }
                        }
                    },
                    new Department
                    {
                        Name = "Córdoba",
                        Cities = new List<City>
                        {
                            new City { Name = "Cerro Colorado" },
                            new City { Name = "Springfield" }
                        }
                    }
                }
            });
            await _context.SaveChangesAsync();
        }
    }
}
