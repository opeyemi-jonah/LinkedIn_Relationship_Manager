using LinkedIn_Relationship_Manager.DBContext;
using LinkedIn_Relationship_Manager.Models;
using LinkedIn_Relationship_Manager.Repositories.Interfaces;

namespace LinkedIn_Relationship_Manager.Repositories.Implementation
{
    public class UserRepository(DataContext db) : IUser
    {
        private readonly DataContext _context = db;

        public string CreateUser(User user)
        {
            string result;
            if (user == null)
            {
                return "No User";
            }

            else
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                result = user.UserId;
            }
            return result;
        }

        public string DeleteUser(User user)
        {
            var usr = _context.Users.Where(user => user.UserId.ToString() == user.UserId.ToString()).FirstOrDefault() ?? null;
            if (usr != null)
            {
                _context.Remove(usr);
                _context.SaveChanges();
                return usr.UserId.ToString();
            }

            return "User deleted successfully";
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User GetUserByUserId(string id)
        {
            var user = _context.Users.Where(user => user.UserId.ToString() == id).FirstOrDefault() ?? null;
            return user;
        }

        public string UpdateUser(User user)
        {
            var usr = _context.Users.Where(user => user.UserId.ToString() == user.UserId.ToString()).FirstOrDefault() ?? null;

            if (usr != null)
            {
                usr.Firstname = user.Firstname;
                usr.Lastname = user.Lastname;
                usr.Email = user.Email;
                usr.PhoneNumber = user.PhoneNumber;
                usr.Password = user.Password;
                usr.Username = user.Username;
                _context.SaveChanges();
                return usr.UserId.ToString();
            }
            return "Updated user";
        }
        
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
