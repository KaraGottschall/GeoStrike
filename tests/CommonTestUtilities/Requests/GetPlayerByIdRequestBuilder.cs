// Solução: GeoStrike | Projeto: CommonTestUtilities
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

using GeoStrike.Communication.Requests;

namespace CommonTestUtilities.Requests;

public class GetPlayerByIdRequestBuilder
{
    public static GetPlayerByIdRequest Build() => new() { PlayerId = Guid.NewGuid() };