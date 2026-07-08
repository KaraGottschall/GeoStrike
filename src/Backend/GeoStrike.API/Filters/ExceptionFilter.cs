#region

using GeoStrike.Comunication.Responses;
using GeoStrike.Exception.ExceptionBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static GeoStrike.Exception.Resources.ResourceMessagesExceptions;
using static Microsoft.AspNetCore.Http.StatusCodes;

#endregion

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