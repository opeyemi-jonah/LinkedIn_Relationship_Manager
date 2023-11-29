using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class Message : IMessage
    {
        public Guid MessageId => throw new NotImplementedException();

        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime SendDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Recipient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MessageType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Comments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
