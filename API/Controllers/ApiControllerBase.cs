using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    
    /// <summary>
    /// Map the Result Type to appropriate status code.
    /// </summary>
    /// <param name="result"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public ActionResult<T> HandleResult<T>(Result<T> result)
        => result switch
        {
            { IsSuccess:true, Data: null } => NotFound(),
            { IsSuccess:true } => Ok(result.Data),
            { IsSuccess:false } => BadRequest(result.ErrorMessage)
        };
    

}