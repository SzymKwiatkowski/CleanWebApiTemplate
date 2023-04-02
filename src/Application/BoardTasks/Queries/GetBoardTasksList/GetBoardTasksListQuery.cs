using AutoMapper;
using MediatR;
using RestApiTemplate.Application.BoardTasks.Models;

namespace RestApiTemplate.Application.BoardTasks.Queries.GetBoardTasksList;

public class GetBoardTasksListQuery : IRequest<List<BoardTaskDto>>
{
    public int BoardId { get; set; }
}
