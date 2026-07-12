// Solução: GeoStrike | Projeto: GeoStrike.API
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 08/07/2026 por Kara Gottschall

#region

global using GeoStrike.Application.UseCases.PlayerBuilding;
global using GeoStrike.Communication.Requests;
global using Microsoft.AspNetCore.Mvc;
global using GeoStrike.Communication.Responses;
global using GeoStrike.Exception.ExceptionBase;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using static GeoStrike.Exception.Resources.ResourceMessagesExceptions;
global using static Microsoft.AspNetCore.Http.StatusCodes;
global using System.Globalization;
global using GeoStrike.API.Filters;
global using GeoStrike.Application;
global using GeoStrike.Infrastructure;
global using GeoStrike.Infrastructure.DataAccess;
global using Microsoft.AspNetCore.Localization;
global using Microsoft.EntityFrameworkCore;
global using GeoStrike.Application.UseCases.Player;
global using GeoStrike.Domain.Entities;
global using System.Text.Json.Serialization;
global using Microsoft.Azure.Cosmos;

#endregion