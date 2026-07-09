// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Entities;

public class Building
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public BuildingType Type { get; init; }
    public short StartLevel { get; private set; } = 1;
}