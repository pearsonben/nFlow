using FluentValidation;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Filters;

public class ValidateAttribute<TValidator> : ActionFilterAttribute where TValidator : IValidator
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        
        var validator = (TValidator)context.HttpContext.RequestServices.GetService(typeof(TValidator));
        
        if (validator == null)
        {
            throw new InvalidOperationException("Validator not found in DI container.");
        }
        
        base.OnActionExecuting(context);
        
    }
}