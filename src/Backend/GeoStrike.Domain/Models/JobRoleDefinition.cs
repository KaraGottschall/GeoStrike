// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 10/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Models;

public class JobRoleDefinition
{
    public JobRoleType Type { get; init; }
    public double BaseWage { get; init; }
}