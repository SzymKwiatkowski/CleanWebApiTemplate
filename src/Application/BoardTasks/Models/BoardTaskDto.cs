using RestApiTemplate.Application.Common.Mappings;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Application.BoardTasks.Models;
public class BoardTaskDto : BaseBoardTaskDto, IMapFrom<BoardTask>
{
    public List<BoardSubtaskDto>? BoardSubtasks { get; set; }
}
