namespace GeoStrike.Infrastructure.DataAccess.EntitiesConfiguration;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public static readonly Guid JohnDoeId = Guid.Parse("41D3A083-4137-439A-8688-B9C6F6A9AB8C");

    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasData(new Player
        {
            Id = JohnDoeId,
            Name = "John Doe",

            Money = 5000000,
            Gold = 5000000,
            Oil = 5000000
        });
    }
}