#region

using GeoStrike.Domain.Entities;
using Microsoft.EntityFrameworkCore;

#endregion

namespace GeoStrike.Infrastructure.DataAccess;

public class GeoStrikeDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Building> Buildings { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerBuilding> PlayerBuildings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GeoStrikeDbContext).Assembly);
    }
}