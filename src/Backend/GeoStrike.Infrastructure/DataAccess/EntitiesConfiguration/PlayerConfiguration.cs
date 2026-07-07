#region

using GeoStrike.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder) { builder.HasKey(p => p.Id); }
}