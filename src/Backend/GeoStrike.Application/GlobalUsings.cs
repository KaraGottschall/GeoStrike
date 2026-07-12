// Solução: GeoStrike | Projeto: GeoStrike.Application
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

#region

global using FluentValidation;
global using FluentValidation.Results;
global using GeoStrike.Application.Configuration;
global using GeoStrike.Application.UseCases.Player;
global using GeoStrike.Application.UseCases.Player.GetPlayerById;
global using GeoStrike.Application.UseCases.PlayerBuilding;
global using GeoStrike.Application.UseCases.PlayerBuilding.Evolve;
global using GeoStrike.Communication.Requests;
global using GeoStrike.Domain.Enums;
global using GeoStrike.Domain.Repositories.Player;
global using GeoStrike.Domain.Repositories.PlayerBuilding;
global using GeoStrike.Exception.ExceptionBase;
global using Microsoft.Extensions.DependencyInjection;
global using static GeoStrike.Exception.Resources.ResourceMessagesExceptions;
global using PlayerBuildingEntity = GeoStrike.Domain.Entities.PlayerBuilding;
global using PlayerEntity = GeoStrike.Domain.Entities.Player;
global using GeoStrike.Domain.Catalog;
global using GeoStrike.Domain.Models;
global using GeoStrike.Domain.Repositories.Catalog.BuildingCatalogRepository;

#endregion