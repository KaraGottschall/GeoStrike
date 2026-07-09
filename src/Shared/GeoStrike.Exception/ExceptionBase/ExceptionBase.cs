// Solução: GeoStrike | Projeto: GeoStrike.Exception
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

namespace GeoStrike.Exception.ExceptionBase;

public class ErrorOnValidationException(IReadOnlyList<string> errorMsg) : GeoStrikeException
{
    public IReadOnlyList<string> GetErrorMessages() => errorMsg;
}