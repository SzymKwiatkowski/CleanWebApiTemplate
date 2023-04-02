namespace RestApiTemplate.Domain.Entities;

public class BoardTask : BaseAuditableEntity
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public PriorityLevel Priority { get; set; }

    public DateTime? DueDate { get; set; }

    public List<BoardSubtask> BoardSubtasks { get; set; } = new List<BoardSubtask>();
}
