#region

using GeoStrike.Comunication.Requests;
using static GeoStrike.Exceptions.Resources.ResourceMessagesExceptions;

#endregion

namespace GeoStrike.Application.UseCases.Building.Evolve;

public class StartEvolvingBuildingUseCase : IStartEvolvingBuildingUseCase
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

        request.CompletionDate = DateTime.UtcNow;
    }
}