#region

using GeoStrike.Comunication.Requests;

#endregion

namespace GeoStrike.Application.UseCases.Building;

public interface IStartEvolvingBuildingUseCase
{
    Task<bool> ExecuteAsync(StartEvolvingBuildingRequest request);
}