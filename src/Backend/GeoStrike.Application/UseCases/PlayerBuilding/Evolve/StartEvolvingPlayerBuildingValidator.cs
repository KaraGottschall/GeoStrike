namespace GeoStrike.Application.UseCases.PlayerBuilding.Evolve;

public class StartEvolvingPlayerBuildingValidator : AbstractValidator<StartEvolvingPlayerBuildingRequest>
{
    public StartEvolvingPlayerBuildingValidator()
    {
        RuleFor(x => x.BuildingId)
            .NotEmpty()
            .WithMessage(BUILDING_ID_REQUIRED);

        RuleFor(x => x.PlayerId)
            .NotEmpty()
            .WithMessage(PLAYER_ID_REQUIRED);
    }
}