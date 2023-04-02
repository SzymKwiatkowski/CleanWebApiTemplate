using MediatR;
using RestApiTemplate.Application.BoardTasks.Models;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Application.BoardTasks.Commands.UpdateBoardTask;

public class UpdateBoardTaskCommand : IRequest<BoardTaskDto>
{
    public int TaskId { get; set; }

    public BoardSubtaskDto? BoardSubtask { get; set; }
}
