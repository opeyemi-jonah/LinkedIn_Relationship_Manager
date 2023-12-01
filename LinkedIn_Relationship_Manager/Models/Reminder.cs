using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class Reminder
    {

        public int ReminderId { get; set; }
        public required string Title { get; set; }
        public DateTime ScheduledAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public DateTime TriggeredAt { get; set; }
        public string? Status { get; set; }

        //Relationhips
        public List<ReminderContact>? ReminderContacts { get; set; }

        //User
        public Guid UserId { get; set; }
        public User? User { get; set; }

        //Contact
        public int ContactId { get; set; }
        public Contact? Contact { get; set; }


    }
}
