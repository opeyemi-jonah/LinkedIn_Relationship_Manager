using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class Reminder : IReminder
    {
        public int ReminderId { get; set; }
        public required string Title { get; set; }
        public DateTime ScheduledAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public DateTime TriggeredAt { get; set; }
        public required string Status { get; set; }
    }
}
