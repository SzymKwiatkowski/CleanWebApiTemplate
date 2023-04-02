
using FluentValidation;

namespace RestApiTemplate.Application.BoardTasks.Commands.CreateBoardTask;

public class CreateBoardTaskCommandValidator : AbstractValidator<CreateBoardTaskCommand>
{
    public CreateBoardTaskCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }
}
