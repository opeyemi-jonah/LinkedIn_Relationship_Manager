namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IReminder
    {
        int ReminderId { get; set; }

        string Title { get; set; }

        DateTime ScheduledAt { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }

        DateTime TriggeredAt { get; set; }

        string Status { get; set; }


    }
}
