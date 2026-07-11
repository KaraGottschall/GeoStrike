// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

using GeoStrike.Domain.Catalog;
using GeoStrike.Domain.Models;

namespace GeoStrike.Application.Configuration;

public static class UpgradingRules
{
    public static double CalculateConstructionCost(BuildingType buildingType, int currentLevel)
    {
        double baseCost = BuildingCatalog.Get(buildingType).BaseConstructionCost;

        double evolutionMultiplier = BuildingRules.EvolutionCostMultiplier(buildingType);
        double baseConstructionFee = BuildingRules.GetConstructionFee(buildingType);

        double structuralCost = (baseCost * Math.Pow(evolutionMultiplier, currentLevel)) + baseConstructionFee;

        return structuralCost
               + CalculatePayroll(BuildingCatalog.Get(buildingType))
               + CalculateMaterialCosts(buildingType, currentLevel);
    }

    private static double CalculatePayroll(BuildingDefinition buildingDefinition)
    {
        double payroll = buildingDefinition.ConstructionCrew.Sum(requirement =>
            requirement.Quantity * JobRoleCatalog.Get(requirement.JobRoleType).BaseWage);

        return payroll;
    }


    private static double CalculateMaterialCosts(BuildingType buildingType, int currentLevel) =>
        /*
         * Custos com materiais de construcao (cada tipo de material envolvido terá um valor por unidade)
         *
         * Pode ser levado em conta os materiais que o jogador já tem em estoque
         */
        1.0;
}