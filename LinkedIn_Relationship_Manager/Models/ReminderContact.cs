
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LinkedIn_Relationship_Manager.Models
{
    public class ReminderContact
    {

        public int UserId { get; set; }
        public User? User { get; set; }

        public int ReminderId { get; set; }
        public Reminder? Reminder { get; set; }

        public int ContactId { get; set; }
        public Contact? Contact { get; set; }
    }
}
