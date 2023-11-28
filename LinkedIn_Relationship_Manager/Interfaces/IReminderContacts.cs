namespace LinkedIn_Relationship_Manager.Interfaces
{
    public interface IReminderContacts
    {
        IUser UserId { get; }
        IReminder ReminderId { get; }

        IContacts ContactId { get; }    
    }
}
