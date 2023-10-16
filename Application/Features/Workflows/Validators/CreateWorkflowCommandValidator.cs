using Application.Features.Workflows.Requests;
using FluentValidation;

namespace Application.Features.Workflows.Validators;

public class CreateWorkflowCommandValidator : AbstractValidator<CreateWorkflowCommand>
{
    public CreateWorkflowCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().NotNull().WithMessage(x => "{Name} parameter must not be null or empty");
        
        RuleFor(x => x.Description)
            .NotEmpty().NotNull().WithMessage("{Description} parameter must not be null or empty\"");
    }
}