using LinkedIn_Relationship_Manager.Models;

namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IReminder
    {
        Task<Reminder> GetReminderByReminderIdAsync(int reminderId);
        Task<IEnumerable<Reminder>> GetAllRemindersAsync();

        Task<Reminder> GetReminderByUserIdAsync(int userId);

        Task<Reminder> GetReminderByContactId(int contactId);

        Task<Reminder> CreateReminderAsync(Reminder reminder);

        Task<Reminder> UpdateReminderAsync(Reminder reminder);

        Task<Reminder> DeleteReminderAsync(int reminderId);

       
    }
}
