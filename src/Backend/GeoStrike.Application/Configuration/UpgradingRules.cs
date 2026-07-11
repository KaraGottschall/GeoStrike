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

        double structuralCost = baseCost * Math.Pow(evolutionMultiplier, currentLevel) + baseConstructionFee;

        return structuralCost
               + CalculatePayroll(BuildingCatalog.Get(buildingType))
               + CalculateMaterialCosts(BuildingCatalog.Get(buildingType));
    }

    private static double CalculatePayroll(BuildingDefinition buildingDefinition)
    {
        double payroll = buildingDefinition.ConstructionCrew.Sum(requirement =>
            requirement.Quantity * JobRoleCatalog.Get(requirement.JobRoleType).BaseWage);

        return payroll;
    }

    private static double CalculateMaterialCosts(BuildingDefinition buildingDefinition)
    {
        /*
         * Tipos de materiais comuns na construção civíl, já que são itens pra construção de edifícios
         *
         * As medidas serao todas 'unidade', mas considero tambem abaixo a sua evolucao:
         * Aco: (no futuro talvez contabilizar por tonelada?)
         * Cimento: (no futuro talvez contabilizar por tonelada?)
         * Concreto: (no futuro medir por metro cubico)
         * Agua: (no futuro medir por metro cubico)
         * Areia: (tambem medir por metro cubico)
         *
         * No futuro, poderá ser levado em conta os materiais que o jogador já tem em estoque
         */
        double materialCost = buildingDefinition.MaterialsRequirement.Sum(requirement =>
            requirement.Quantity * MaterialCatalog.Get(requirement.MaterialType).Price
        );

        return materialCost;
    }
}