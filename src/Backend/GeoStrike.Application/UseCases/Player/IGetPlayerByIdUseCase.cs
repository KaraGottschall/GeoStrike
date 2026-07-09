// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

namespace GeoStrike.Application.UseCases.Player;

public interface IGetPlayerByIdUseCase
{
    Task<PlayerEntity?> ExecuteAsync(GetPlayerByIdRequest request);
}