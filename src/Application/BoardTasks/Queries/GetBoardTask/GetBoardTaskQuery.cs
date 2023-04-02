using AutoMapper;
using MediatR;
using RestApiTemplate.Application.BoardTasks.Models;

namespace RestApiTemplate.Application.BoardTasks.Queries.GetBoardTask;

public class GetBoardTaskQuery : IRequest<List<BoardTaskDto>>
{
    public int TaskId { get; set; }
}
