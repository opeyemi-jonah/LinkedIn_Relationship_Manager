
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LinkedIn_Relationship_Manager.Models
{
    public class ReminderContact
    {

        [Key, Column(Order = 0)]
        public int UserId { get; set; }

        [Key, Column(Order = 1)]
        public int ReminderId { get; set; }

        [Key, Column(Order = 2)]
        public int ContactId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("ReminderId")]
        public Reminder? Reminder { get; set; }

        [ForeignKey("ContactId")]
        public Contact? Contact { get; set; }
    }
}
