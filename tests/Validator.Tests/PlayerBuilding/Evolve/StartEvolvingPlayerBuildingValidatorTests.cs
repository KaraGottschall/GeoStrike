#region

using CommonTestUtilities.Requests;
using FluentValidation.Results;
using GeoStrike.Application.UseCases.PlayerBuilding.Evolve;
using GeoStrike.Communication.Requests;
using Shouldly;

#endregion

namespace Validator.Tests.PlayerBuilding.Evolve;

public class StartEvolvingPlayerBuildingValidatorTests
{
    [Fact]
    public void Success()
    {
        StartEvolvingPlayerBuildingRequest request = StartEvolvingPlayerBuildingRequestBuilder.Build();
        StartEvolvingPlayerBuildingValidator validator = new();

        ValidationResult? result = validator.Validate(request);

        result.IsValid.ShouldBeTrue();
    }

    [Fact]
    public void Validate_ShouldHaveError_WhenPlayerIdIsEmpty()
    {
        StartEvolvingPlayerBuildingRequest request = StartEvolvingPlayerBuildingRequestBuilder.Build();
        StartEvolvingPlayerBuildingValidator validator = new();

        request.PlayerId = Guid.Empty;

        ValidationResult? result = validator.Validate(request);

        result.IsValid.ShouldBeFalse();
        result.Errors.Count.ShouldBe(1);
        result.Errors.Any(x => x.PropertyName == nameof(request.PlayerId)).ShouldBeTrue();
    }

    [Fact]
    public void Validate_ShouldHaveError_WhenBuildingIdIsEmpty()
    {
        StartEvolvingPlayerBuildingRequest request = StartEvolvingPlayerBuildingRequestBuilder.Build();
        StartEvolvingPlayerBuildingValidator validator = new();

        request.BuildingId = Guid.Empty;

        ValidationResult? result = validator.Validate(request);

        result.IsValid.ShouldBeFalse();
        result.Errors.Count.ShouldBe(1);
        result.Errors.Any(x => x.PropertyName == nameof(request.BuildingId)).ShouldBeTrue();
    }
}