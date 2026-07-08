#region

using FluentValidation;
using GeoStrike.Comunication.Requests;
using static GeoStrike.Exception.Resources.ResourceMessagesExceptions;

#endregion

namespace GeoStrike.Application.UseCases.PlayerBuilding.Evolve;

public class StartEvolvingBuildingValidator : AbstractValidator<StartEvolvingPlayerBuildingRequest>
{
    public StartEvolvingBuildingValidator()
    {
        RuleFor(x => x.BuildingId)
            .NotEmpty()
            .WithMessage(BUILDING_ID_REQUIRED);

        RuleFor(x => x.PlayerId)
            .NotEmpty()
            .WithMessage(PLAYER_ID_REQUIRED);
    }
}