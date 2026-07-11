// Solução: GeoStrike | Projeto: GeoStrike.Domain
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 11/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Models;

public class MaterialDefinition
{
    public MaterialType Type { get; init; }
    public double Price { get; init; }
}