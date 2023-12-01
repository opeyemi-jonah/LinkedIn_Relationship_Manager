
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkedIn_Relationship_Manager.Models
{
    public class User
    {
        public string UserId { get; set; } = new Guid().ToString();
        public required string Username { get; set; } 
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        

        //Relationships
        public virtual List<ReminderContact>? ReminderContacts { get; set; }
        public virtual List<LinkedInAccount>? LinkedInAccounts { get; set; }

        public virtual List<Message>? Messages { get; set; }

        //Reminder
        public virtual Reminder? Reminder { get; set; }

        public int ReminderId { get; set; }

        //Contact
        public int ContactId { get; set; }
        public virtual Contact? Contact { get; set; }

        //Message
        public Guid MessageId { get; set; }
        public Message? Message { get; set; }




    }
}
