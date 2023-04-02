using RestApiTemplate.Application.Common.Mappings;
using RestApiTemplate.Domain.Entities;
using RestApiTemplate.Domain.Enums;

namespace RestApiTemplate.Application.BoardTasks.Models;
public class BoardSubtaskDto : IMapFrom<BoardSubtask>
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public PriorityLevel Priority { get; set; }

    public DateTime? DueDate { get; set; }
}
