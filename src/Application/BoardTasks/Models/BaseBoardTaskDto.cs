using RestApiTemplate.Application.Common.Mappings;
using RestApiTemplate.Domain.Entities;
using RestApiTemplate.Domain.Enums;

namespace RestApiTemplate.Application.BoardTasks.Models;

public class BaseBoardTaskDto 
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public PriorityLevel Priority { get; set; }

    public DateTime? DueDate { get; set; }
}
