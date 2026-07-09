// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

namespace GeoStrike.Application.UseCases.Player.GetPlayerById;

public class GetPlayerByIdUseCase(IReadOnlyPlayerRepository readOnlyPlayerRepository) : IGetPlayerByIdUseCase
{
    public async Task<PlayerEntity?> ExecuteAsync(GetPlayerByIdRequest request)
    {
        await ValidateAndThrowOnFailures(request);
        return await readOnlyPlayerRepository.GetByIdAsync(request.PlayerId);
    }

    private static async Task ValidateAndThrowOnFailures(GetPlayerByIdRequest request)
    {
        GetPlayerByIdValidator validator = new();
        ValidationResult result = await validator.ValidateAsync(request);

        if (result.IsValid) return;

        IReadOnlyList<string> errorMessages = [.. result.Errors.Select(e => e.ErrorMessage)];
        throw new ErrorOnValidationException(errorMessages);
    }
}