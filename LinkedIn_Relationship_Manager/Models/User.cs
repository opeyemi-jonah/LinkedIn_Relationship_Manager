
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkedIn_Relationship_Manager.Models
{
    public class User
    {
        public int UserId { get; set; }
        public required string Username { get; set; } 
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        

        //Relationships
        public virtual List<ReminderContact>? ReminderContacts { get; set; }
        public virtual List<LinkedInAccount>? LinkedInAccounts { get; set; }

        public virtual List<UserMessage>? UserMessages { get; set; }


    }
}
