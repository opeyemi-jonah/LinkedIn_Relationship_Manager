using LinkedIn_Relationship_Manager.Repositories.Interfaces;


namespace LinkedIn_Relationship_Manager.Models
{
    public class ReminderContact
    {
        public int ReminderContactId { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public int ReminderId { get; set; }
        public Reminder? Reminder { get; set; }

        public int ContactId { get; set; }
        public Contact? Contact { get; set; }
    }
}
