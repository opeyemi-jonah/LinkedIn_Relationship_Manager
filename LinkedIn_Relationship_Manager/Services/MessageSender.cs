using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Services
{
    public class MessageSender  : IMessageSender
    {
            public void SendTextMessage(string recipient, string messageContent)
            {
                // Implement logic to send a text message
            }

            public void SendEmailMessage(string recipientEmail, string subject, string messageBody)
            {
                // Implement logic to send an email
            }

            public void SendNotification(int userId, string message)
            {
                // Implement logic to send a notification
            }

    }
}
