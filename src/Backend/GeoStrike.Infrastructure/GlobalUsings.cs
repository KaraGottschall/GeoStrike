// Solução: GeoStrike | Projeto: GeoStrike.Infrastructure
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

#region

global using GeoStrike.Domain.Entities;
global using GeoStrike.Domain.Enums;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using GeoStrike.Domain.Repositories.Building;
global using GeoStrike.Domain.Repositories.Player;
global using PlayerEntity = GeoStrike.Domain.Entities.Player;
global using PlayerBuildingEntity = GeoStrike.Domain.Entities.PlayerBuilding;
global using GeoStrike.Domain.Repositories.PlayerBuilding;
global using GeoStrike.Infrastructure.DataAccess.Repositories.Building;
global using GeoStrike.Infrastructure.DataAccess.Repositories.Player;
global using GeoStrike.Infrastructure.DataAccess.Repositories.PlayerBuilding;
global using Microsoft.Extensions.DependencyInjection;

#endregion