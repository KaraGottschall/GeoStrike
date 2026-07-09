// Solução: GeoStrike | Projeto: Validator.Tests
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

global using CommonTestUtilities.Requests;
global using FluentValidation.Results;
global using GeoStrike.Application.UseCases.Player.GetPlayerById;
global using GeoStrike.Communication.Requests;
global using GeoStrike.Application.UseCases.PlayerBuilding.Evolve;
global using Shouldly;
global using static GeoStrike.Exception.Resources.ResourceMessagesExceptions;
