using LinkedIn_Relationship_Manager.Models;

namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IUser : IDisposable
    {
        //Guid UserId { get; set; }
        //string Username { get; set; }
        //string Firstname { get; set; }
        //string Lastname { get; set; }
        //string Password { get; set; }
        //string Email { get; set; }
        //string PhoneNumber { get; set; }

        IEnumerable<User> GetAllUsers();

        User GetUserByUserId(string id);

        string CreateUser(User user);

        string UpdateUser(User user);
        string DeleteUser(User user);


    }
}
