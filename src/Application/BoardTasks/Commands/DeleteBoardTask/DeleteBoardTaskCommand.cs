using MediatR;

namespace RestApiTemplate.Application.BoardTasks.Commands.DeleteBoardTask;

public class DeleteBoardTaskCommand : IRequest<int>
{
    public int TaskId { get; set; }
}
