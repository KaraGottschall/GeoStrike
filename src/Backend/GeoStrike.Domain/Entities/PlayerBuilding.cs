namespace GeoStrike.Domain.Entities;

public class PlayerBuilding
{
    public Guid Id { get; set; }

    // Relacionamento com o Jogador
    public Guid PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    // Relacionamento com o modelo da Construção
    public Guid BuildingId { get; set; }
    public Building Building { get; set; } = null!;

    // Dados específicos da instância do jogador
    public int Level { get; set; }
    public int Quantity { get; set; }
}