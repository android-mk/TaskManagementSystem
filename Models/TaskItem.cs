namespace TaskManagementSystem.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public required string Title { get; set; } // Mark as required
        public string? Description { get; set; }   // Mark as nullable
        public required string Status { get; set; } // Mark as required
        public DateTime DueDate { get; set; }
        public string? AssignedTo { get; set; }     // Mark as nullable
    }
}