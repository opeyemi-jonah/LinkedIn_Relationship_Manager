using LinkedIn_Relationship_Manager.Models;

namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IMessage
    {
        Task<string> GetMessageByMessageIdAsync(int id);
        Task<int> GetMessageCountAsync();
        Task<Message> CreateMessageAsync(Message message);
        Task<Message> UpdateMessageAsync(Message message);
        Task<Message> DeleteMessageAsync(Message message);
        Task<string> PromptChatGPT(string prompt);
        

    }
}
