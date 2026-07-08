#region

using GeoStrike.Comunication.Requests;

#endregion

namespace GeoStrike.Application.UseCases.PlayerBuilding;

public interface IStartEvolvingPlayerBuildingUseCase
{
    Task<bool> ExecuteAsync(StartEvolvingPlayerBuildingRequest request);
}