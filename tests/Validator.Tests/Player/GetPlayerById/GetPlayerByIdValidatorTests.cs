// Solução: GeoStrike | Projeto: Validator.Tests
// Licenciado sob a Licença MIT. Veja o arquivo LICENSE na raiz para mais detalhes.
// Criado em: 09/07/2026 por Kara Gottschall

namespace Validator.Tests.Player.GetPlayerById;

public class GetPlayerByIdValidatorTests
{
    [Fact]
    public void Success()
    {
        GetPlayerByIdRequest request = GetPlayerByIdRequestBuilder.Build();
        GetPlayerByIdValidator validator = new();

        ValidationResult? result = validator.Validate(request);

        result.IsValid.ShouldBeTrue();
    }

    [Fact]
    public void Validate_ShouldHaveError_WhenPlayerIdIsEmpty()
    {
        GetPlayerByIdRequest request = GetPlayerByIdRequestBuilder.Build();
        GetPlayerByIdValidator validator = new();

        request.PlayerId = Guid.Empty;

        ValidationResult? result = validator.Validate(request);

        result.IsValid.ShouldBeFalse();
        result.Errors.Count.ShouldBe(1);
        result.Errors[0].ErrorMessage.ShouldBe(PLAYER_ID_REQUIRED);
    }
}