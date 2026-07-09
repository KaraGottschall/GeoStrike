// Solução: GeoStrike | Projeto: GeoStrike.Communication
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 07/07/2026 por Kara Gottschall

namespace GeoStrike.Communication.Requests;

public class StartEvolvingPlayerBuildingRequest
{
    public Guid BuildingId { get; set; }
    public Guid PlayerId { get; set; }
}