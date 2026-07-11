// Solução: GeoStrike | Projeto: GeoStrike.Domain.Catalog
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 10/07/2026 por Kara Gottschall

namespace GeoStrike.Domain.Catalog;

public static class JobRoleCatalog
{
    private static readonly Dictionary<JobRoleType, JobRoleDefinition> Definitions;

    static JobRoleCatalog()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        const string resourceName = "GeoStrike.Domain.Catalog.StaticData.jobRoles.json";

        using Stream stream = assembly.GetManifestResourceStream(resourceName)
                              ?? throw new FileNotFoundException(
                                  $"Recurso embutido '{resourceName}' não foi encontrado.");

        using StreamReader reader = new(stream);
        string json = reader.ReadToEnd();

        JobRoleCatalogRoot? root =
            JsonSerializer.Deserialize(json, JobRoleCatalogJsonContext.Default.JobRoleCatalogRoot);

        if (root?.JobRoles == null)
            throw new InvalidOperationException("Falha ao carregar o catálogo de edifícios do arquivo JSON.");

        Definitions = root.JobRoles.ToDictionary(j => j.Type);
    }

    public static JobRoleDefinition Get(JobRoleType type) =>
        Definitions.TryGetValue(type, out JobRoleDefinition? definition)
            ? definition
            : throw new KeyNotFoundException($"A função do tipo '{type}' não foi mapeado no catálogo.");
}

[JsonSerializable(typeof(JobRoleCatalogRoot))]
[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    Converters = [typeof(JsonStringEnumConverter<JobRoleType>)]
)]
internal partial class JobRoleCatalogJsonContext : JsonSerializerContext;

internal class JobRoleCatalogRoot
{
    public List<JobRoleDefinition> JobRoles { get; set; } = [];
}