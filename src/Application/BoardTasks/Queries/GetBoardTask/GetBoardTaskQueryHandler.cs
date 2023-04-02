using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Application.BoardTasks.Models;
using RestApiTemplate.Application.Common.Interfaces;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Application.BoardTasks.Queries.GetBoardTask;

public class GetBoardTaskQueryHandler : IRequestHandler<GetBoardTaskQuery, List<BoardTaskDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetBoardTaskQueryHandler(IApplicationDbContext context, IMapper mapper)
    {

        _context = context;
        _mapper = mapper;
    }

    public async Task<List<BoardTaskDto>> Handle(GetBoardTaskQuery request, CancellationToken cancellationToken)
    {
        return _mapper.Map<List<BoardTaskDto>>
            (await _context.BoardTasks
            .Where(t => t.Id == request.TaskId)
            .Include(b => b.BoardSubtasks)
            .ToListAsync(cancellationToken));
    }
}
