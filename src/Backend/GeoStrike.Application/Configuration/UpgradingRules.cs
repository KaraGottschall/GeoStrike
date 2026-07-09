// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

using GeoStrike.Domain.Catalogs;

namespace GeoStrike.Application.Configuration;

public static class UpgradingRules
{
    private static readonly Dictionary<string, double> JobRoleSalary = new()
    {
        { "Engineer", 2500.00 },
        { "MasterBuilder", 1000.00 },
        { "Workman", 800.00 },
    };

    public static double CalculateConstructionCost(BuildingType buildingType, int currentLevel)
    {
        double baseCost = BuildingCatalog.Get(buildingType).BaseConstructionCost;

        double evolutionMultiplier = BuildingRules.EvolutionCostMultiplier(buildingType);
        double baseConstructionFee = BuildingRules.GetConstructionFee(buildingType);

        double structuralCost = baseCost * Math.Pow(evolutionMultiplier, currentLevel) + baseConstructionFee;

        return structuralCost + CalculatePayroll(buildingType) + CalculateMaterialCosts(buildingType, currentLevel);
    }

    private static double CalculatePayroll(BuildingType buildingType) =>
        /*
         * Quantidade de funcionarios especializados na construcao daquele edificio * Salario minimo da categoria do funcionario
         * (gerente de obras, engenheiro etc etc)
         */
        // ideia inicial: criar um dicionario ou aqui ou no banco de dados de <funcionario, salario> e trazer o valor
        1.0;

    private static double CalculateMaterialCosts(BuildingType buildingType, int currentLevel) =>
        /*
         * Custos com materiais de construcao (cada tipo de material envolvido terá um valor por unidade)
         *
         * Pode ser levado em conta os materiais que o jogador ja tem em estoque
         */
        1.0;
}