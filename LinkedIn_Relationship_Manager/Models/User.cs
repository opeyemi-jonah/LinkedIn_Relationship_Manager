namespace LinkedIn_Relationship_Manager.Models
{
    public class User : IUser
    {
        string username;
        string firstname;
        string lastname;
        string password;
        string email;
        string phoneNumber;
        Guid userId;
        public User()
        {
            Guid userId = Guid.NewGuid();
        }


    }
}
