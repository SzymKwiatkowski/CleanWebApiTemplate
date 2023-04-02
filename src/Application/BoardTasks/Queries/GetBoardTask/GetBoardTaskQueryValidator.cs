using FluentValidation;

namespace RestApiTemplate.Application.BoardTasks.Queries.GetBoardTask;

public class GetBoardTaskQueryValidator : AbstractValidator<GetBoardTaskQuery>
{
    public GetBoardTaskQueryValidator()
    {
        RuleFor(v => v.TaskId)
            .GreaterThan(0)
            .NotNull()
            .NotEmpty();
    }
}
