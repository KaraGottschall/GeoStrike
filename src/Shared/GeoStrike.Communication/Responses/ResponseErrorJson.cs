// Solução: GeoStrike | Projeto: GeoStrike.Communication
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Communication.Responses;

public class ResponseErrorJson
{
    public ResponseErrorJson(IReadOnlyList<string> errors) => Errors = errors;
    public ResponseErrorJson(string errors) => Errors = [errors];
    public IReadOnlyList<string> Errors { get; }
}