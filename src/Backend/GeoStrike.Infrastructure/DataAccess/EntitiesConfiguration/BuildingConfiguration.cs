#region

using GeoStrike.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder) { builder.HasKey(b => b.Id); }
}