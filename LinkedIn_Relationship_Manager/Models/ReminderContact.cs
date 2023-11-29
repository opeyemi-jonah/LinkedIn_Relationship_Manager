using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class ReminderContact : IReminderContacts
    {
        public Guid UserId { get; set; }
        public required User User { get; set; }
        public int ReminderId { get; set; }
        public required Reminder Reminder { get; set; }

        public int ContactId { get; set; }
        public Contact ?Contact { get; set; }
    }
}
