using AutoMapper;
using MediatR;
using RestApiTemplate.Application.BoardTasks.Models;
using RestApiTemplate.Application.Common.Exceptions;
using RestApiTemplate.Application.Common.Interfaces;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Application.BoardTasks.Commands.UpdateBoardTask;

public class UpdateBoardTaskCommandHandler : IRequestHandler<UpdateBoardTaskCommand, BoardTaskDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateBoardTaskCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BoardTaskDto> Handle(UpdateBoardTaskCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.BoardTasks.FindAsync(request.TaskId, cancellationToken);

        if (entity == null)
            throw new NotFoundException($"Task with id {request.TaskId} not found");

        if (request.BoardSubtask == null)
            throw new InvalidOperationException("Board subtask is incorrect");

        var boardSubtask = new BoardSubtask
        {
            Title = request.BoardSubtask.Title,
            Priority = request.BoardSubtask.Priority,
            DueDate = request.BoardSubtask.DueDate,
            Description = request.BoardSubtask.Description
        };

        entity.BoardSubtasks.Add(boardSubtask);

        _context.BoardTasks.Update(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return _mapper.Map<BoardTaskDto>(entity);
    }
}
