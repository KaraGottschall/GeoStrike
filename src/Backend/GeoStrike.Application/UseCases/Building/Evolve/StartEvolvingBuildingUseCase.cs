#region

using GeoStrike.Comunication.Requests;
using GeoStrike.Domain.Repositories.Player;
using static GeoStrike.Exceptions.Resources.ResourceMessagesExceptions;

#endregion

namespace GeoStrike.Application.UseCases.Building.Evolve;

public class StartEvolvingBuildingUseCase(IReadOnlyPlayerRepository readOnlyPlayerRepository)
    : IStartEvolvingBuildingUseCase
{
    public async Task<bool> ExecuteAsync(StartEvolvingBuildingRequest request)
    {
        await ValidateAndThrowOnFailures(request);

        return true;
    }

    private async Task ValidateAndThrowOnFailures(StartEvolvingBuildingRequest request)
    {
        if (request.CompletionDate.HasValue && request.CompletionDate > DateTime.UtcNow)
            throw new InvalidOperationException(BUILDING_ALREADY_EVOLVING);

        bool playerHasEnoughMoney = await readOnlyPlayerRepository.HasMoneyEnough(request.PlayerId, 0.0);
        // if (!playerHasEnoughMoney)
        //     throw new 

        request.CompletionDate = DateTime.UtcNow;
    }
}