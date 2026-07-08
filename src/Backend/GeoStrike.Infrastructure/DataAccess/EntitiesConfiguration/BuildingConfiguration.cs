#region

using GeoStrike.Domain.Entities;
using GeoStrike.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public static readonly Guid HeadquartersTemplateId = Guid.Parse("CDEAFBCE-68B1-4127-940A-A6211B1A43D7");

    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasKey(b => b.Id);

        builder.HasData(new Building
        {
            Id = HeadquartersTemplateId,
            Type = BuildingType.HeadQuarter
        });
    }
}