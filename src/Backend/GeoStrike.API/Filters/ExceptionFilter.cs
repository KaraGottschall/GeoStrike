namespace GeoStrike.API.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is ErrorOnValidationException errorOnValidationException)
        {
            context.HttpContext.Response.StatusCode = Status400BadRequest;
            context.Result =
                new BadRequestObjectResult(new ResponseErrorJson(errorOnValidationException.GetErrorMessages()));
        }
        else
        {
            context.HttpContext.Response.StatusCode = Status500InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorJson(UNKNOWN_ERROR));
        }
    }
}