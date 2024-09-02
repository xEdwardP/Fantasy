using Fantasy.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace Fantasy.Backend.Data;

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
        await CheckTeamsAsync();
    }

    private async Task CheckCountriesAsync()
    {
        if (!_context.Countries.Any())
        {
            var countriesSQLScript = File.ReadAllText("Data\\Countries.sql");
            await _context.Database.ExecuteSqlRawAsync(countriesSQLScript);
        }
    }

    private async Task CheckTeamsAsync()
    {
        if (!_context.Teams.Any())
        {
            foreach (var country in _context.Countries)
            {
                _context.Teams.Add(new Team { Name = country.Name, Country = country! });
                if (country.Name == "Honduras")
                {
                    _context.Teams.Add(new Team { Name = "CD Olimpia", Country = country! });
                    _context.Teams.Add(new Team { Name = "CD Marathon", Country = country! });
                    _context.Teams.Add(new Team { Name = "Real España", Country = country! });
                    _context.Teams.Add(new Team { Name = "CD Motagua", Country = country! });
                    _context.Teams.Add(new Team { Name = "Deportes Savio", Country = country! });
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
