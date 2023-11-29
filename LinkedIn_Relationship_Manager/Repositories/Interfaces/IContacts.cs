namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IContacts
    {
        int ContactId { get; set; }

        string Firstname { get; set; }
        string Lastname { get; set; }

        string Email { get; set; }
        string PhoneNumber { get; set; }

        string ProfileLink { get; set; }

        string JobTitle { get; set; }

        string JobDescription { get; set; }

        string Company { get; set; }



    }
}
