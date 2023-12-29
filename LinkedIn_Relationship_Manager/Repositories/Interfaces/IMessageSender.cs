namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IMessageSender : IMessage
    {
        // Send a text message
        void SendTextMessage(string recipient, string messageContent);

        // Send an email message
        void SendEmailMessage(string recipientEmail, string subject, string messageBody);

        // Send a notification message
        void SendNotification(int userId, string message);
    }
}
