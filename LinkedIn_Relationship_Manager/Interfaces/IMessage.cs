namespace LinkedIn_Relationship_Manager.Interfaces
{
    public interface IMessage
    {
        Guid MessageId { get; }
        string Body { get; set; }

        DateTime SendDate { get; set; }

        DateTime CreatedAt { get; set; }

        string Subject { get; set; }    

        string Recipient { get; set; }  

        string Status { get; set; }

        string MessageType { get; set; }

        string Comments { get; set; }
    }
}
