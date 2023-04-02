namespace RestApiTemplate.Domain.Entities;

public class BoardSubtask : BaseAuditableEntity
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public PriorityLevel Priority { get; set; }

    public DateTime? DueDate { get; set; }

    public BoardTask? BoardTask { get; set; }

    public int? BoardTaskId { get; set; }
}
