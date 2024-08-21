namespace Presentation.Validators;

using FluentValidation;
using Presentation.Requests;

public class UpdatePresentationValidator : AbstractValidator<UpdatePresentationRequest>
{
    public UpdatePresentationValidator()
    {
        _ = this.RuleFor(r => r.UserId).NotEqual(Guid.Empty).WithMessage("An user id was not supplied to Update the review.");
        _ = this.RuleFor(r => r.Title).NotEqual(string.Empty).WithMessage("A title cannot be empty");
    }
}
