namespace GeoStrike.Exception.ExceptionBase;

public class ErrorOnValidationException(IReadOnlyList<string> errorMsg) : GeoStrikeException
{
    public IReadOnlyList<string> GetErrorMessages() => errorMsg;
}