using MediatR;
using RestApiTemplate.Application.Common.Interfaces;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Application.BoardTasks.Commands.CreateBoardTask;

public class CreateBoardTaskCommandHandler : IRequestHandler<CreateBoardTaskCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateBoardTaskCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateBoardTaskCommand request, CancellationToken cancellationToken)
    {
        var entity = new BoardTask
        {
            Title = request.Title,
            Description = request.Description,
            Priority = Domain.Enums.PriorityLevel.None,
            DueDate = request.DueDate
        };

        _context.BoardTasks.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
