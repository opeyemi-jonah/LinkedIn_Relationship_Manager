using System;

namespace LinkedIn_Relationship_Manager.Interfaces
{
    public interface ILinkedInAccount
    {
        Guid UserId {  get; set; }

        int LinkedInAccountId { get; set; }

        string ProfileLink { get; set; }
    }
}
