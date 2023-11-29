using LinkedIn_Relationship_Manager.DBContext;
using LinkedIn_Relationship_Manager.Models;
using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Repositories.Implementation
{
    public class UserRepository : IUser
    {
        private readonly DataContext _context;

        public UserRepository(DataContext db)
        {
            _context = db;
        }
        public string CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public string DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserId(string id)
        {
            throw new NotImplementedException();
        }

        public string UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
