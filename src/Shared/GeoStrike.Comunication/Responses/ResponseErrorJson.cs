namespace GeoStrike.Comunication.Responses;

public class ResponseErrorJson
{
    public ResponseErrorJson(IReadOnlyList<string> errors) => Errors = errors;
    public ResponseErrorJson(string errors) => Errors = [errors];
    public IReadOnlyList<string> Errors { get; }
}