
using FluentValidation;

namespace RestApiTemplate.Application.BoardTasks.Commands.UpdateBoardTask;

public class UpdateBoardTaskCommandValidator : AbstractValidator<UpdateBoardTaskCommand>
{
    public UpdateBoardTaskCommandValidator()
    {
        RuleFor(v => v.TaskId)
            .NotNull()
            .NotEmpty();
    }
}
