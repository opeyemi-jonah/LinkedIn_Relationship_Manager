using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class Message
    {
        public Guid? MessageId => new();

        public required string Body { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public required string Subject { get; set; }
        public required string Recipient { get; set; }
        public string? Status { get; set; }
        public string? MessageType { get; set; }
        public string? Comments { get; set; }

        //Relationship
        public User? User { get; set; }
    }
}
