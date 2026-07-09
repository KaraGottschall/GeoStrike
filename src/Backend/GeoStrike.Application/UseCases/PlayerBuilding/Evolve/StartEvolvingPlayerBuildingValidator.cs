// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

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