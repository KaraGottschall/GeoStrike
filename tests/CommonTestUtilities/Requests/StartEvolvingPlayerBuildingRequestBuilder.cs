// Solução: GeoStrike | Projeto: CommonTestUtilities
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

#region

using GeoStrike.Communication.Requests;

#endregion

namespace CommonTestUtilities.Requests;

public class StartEvolvingPlayerBuildingRequestBuilder
{
    public static StartEvolvingPlayerBuildingRequest Build() => new()
    {
        PlayerId = Guid.NewGuid(),
        BuildingId = Guid.NewGuid(),
    };
}