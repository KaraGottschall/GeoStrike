// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Entities;

public class PlayerBuilding
{
    public Guid Id { get; set; }

    // Relacionamento com o Jogador
    public Guid PlayerId { get; set; }
    public PlayerEntity Player { get; set; } = null!;

    // Relacionamento com o modelo da Construção
    public Guid BuildingId { get; set; }
    public Building Building { get; set; } = null!;

    // Dados específicos da instância do jogador
    public int Level { get; set; }
    public int Quantity { get; set; }
}