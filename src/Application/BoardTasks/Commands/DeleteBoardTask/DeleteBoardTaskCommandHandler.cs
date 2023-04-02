using MediatR;
using RestApiTemplate.Application.Common.Exceptions;
using RestApiTemplate.Application.Common.Interfaces;

namespace RestApiTemplate.Application.BoardTasks.Commands.DeleteBoardTask;

public class DeleteBoardTaskCommandHandler : IRequestHandler<DeleteBoardTaskCommand, int>
{
    private readonly IApplicationDbContext _context;

    public DeleteBoardTaskCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(DeleteBoardTaskCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.BoardTasks.FindAsync(request.TaskId, cancellationToken);

        if (entity == null)
            throw new NotFoundException($"BoardTask with Id {request.TaskId} not found");

        _context.BoardTasks.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
