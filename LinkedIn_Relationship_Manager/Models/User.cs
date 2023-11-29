using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Models
{
    public class User : IUser
    {
        //string username { get; set; }
        //string firstname { get; set; }
        //string ?lastname { get; set; }
        //string password { get; set; }
        //string email { get; set; }
        //string ?phoneNumber { get; set; }
        //Guid userId { get; }

        public Guid UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } 
        public string Firstname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public User() => UserId = Guid.NewGuid();
    }
}
