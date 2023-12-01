using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class LinkedInAccount
    {
        public int UserId { get; set; }
        public int LinkedInAccountId { get; set; }
        public string? ProfileLink { get; set; }

        //Relationship
        public User? User { get; set; }
    }
}
