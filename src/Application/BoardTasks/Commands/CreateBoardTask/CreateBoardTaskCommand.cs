using MediatR;
using RestApiTemplate.Application.BoardTasks.Models;

namespace RestApiTemplate.Application.BoardTasks.Commands.CreateBoardTask;

public class CreateBoardTaskCommand : BaseBoardTaskDto, IRequest<int>
{
}
