using LinkedIn_Relationship_Manager.Repositories.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkedIn_Relationship_Manager.Models
{
    public class Contact
    {

        public int ContactId { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public  string ProfileLink { get; set; } = string.Empty;
        public  string JobTitle { get; set; } = string.Empty;
        public string? JobDescription { get; set; }
        public string? Company { get; set; }

        //Relationships
        public List<ReminderContact>? ReminderContacts { get; set; }

    }
}
