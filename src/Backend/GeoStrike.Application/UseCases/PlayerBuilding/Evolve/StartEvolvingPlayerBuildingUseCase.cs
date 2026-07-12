// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

public class StartEvolvingPlayerBuildingUseCase(
    IReadOnlyPlayerRepository readOnlyPlayerRepository,
    IWriteOnlyPlayerBuildingRepository writeOnlyPlayerBuildingRepository,
    IReadOnlyBuildingCatalogRepository readOnlyBuildingCatalogRepository
)
    : IStartEvolvingPlayerBuildingUseCase
{
    public async Task<bool> ExecuteAsync(StartEvolvingPlayerBuildingRequest request)
    {
        await ValidateAndThrowOnFailures(request);

        PlayerEntity? player = await readOnlyPlayerRepository.GetByIdAsync(request.PlayerId);
        if (player == null) throw new KeyNotFoundException("Jogador não encontrado.");

        PlayerBuildingEntity? playerBuilding =
            player.Buildings.FirstOrDefault(pb => pb.BuildingId == request.BuildingId);

        if (playerBuilding == null) throw new InvalidOperationException("O jogador não possui essa construção.");

        // if (request.CompletionDate.HasValue && request.CompletionDate > DateTime.UtcNow)
        //     throw new InvalidOperationException(ResourceMessagesExceptions.BUILDING_ALREADY_EVOLVING);

        BuildingDefinition? buildingDefinition =
            await readOnlyBuildingCatalogRepository.GetByTypeAsync(playerBuilding.Building.Type);

        if (buildingDefinition == null)
            throw new KeyNotFoundException("Configuração do edifício não encontrada no catálogo do Cosmos.");

        double costToUpgrade = UpgradingRules.CalculateConstructionCost(buildingDefinition, playerBuilding.Level);

        if (!player.HasMoneyEnough(costToUpgrade)) return false;

        await writeOnlyPlayerBuildingRepository.IncreasePlayerBuildingLevelBy(request.PlayerId, request.BuildingId, 1);

        return true;
    }

    private static async Task ValidateAndThrowOnFailures(StartEvolvingPlayerBuildingRequest request)
    {
        StartEvolvingPlayerBuildingValidator validator = new();
        ValidationResult result = await validator.ValidateAsync(request);

        if (result.IsValid) return;

        IReadOnlyList<string> errorMessages = [.. result.Errors.Select(e => e.ErrorMessage)];
        throw new ErrorOnValidationException(errorMessages);
    }
}