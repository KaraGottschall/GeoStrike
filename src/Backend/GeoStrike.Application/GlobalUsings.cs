#region

global using GeoStrike.Domain.Enums;
global using FluentValidation.Results;
global using GeoStrike.Application.Configuration;
global using GeoStrike.Communication.Requests;
global using GeoStrike.Domain.Repositories.Player;
global using GeoStrike.Domain.Repositories.PlayerBuilding;
global using GeoStrike.Exception.ExceptionBase;
global using PlayerBuildingEntity = GeoStrike.Domain.Entities.PlayerBuilding;
global using PlayerEntity = GeoStrike.Domain.Entities.Player;
global using FluentValidation;
global using static GeoStrike.Exception.Resources.ResourceMessagesExceptions;
global using GeoStrike.Application.UseCases.PlayerBuilding;
global using GeoStrike.Application.UseCases.PlayerBuilding.Evolve;
global using Microsoft.Extensions.DependencyInjection;

#endregion