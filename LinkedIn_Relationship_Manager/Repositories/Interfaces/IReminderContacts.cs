namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IReminderContacts
    {
        Guid UserId { get; }
        int ReminderId { get; }

        int ContactId { get; }
    }
}
