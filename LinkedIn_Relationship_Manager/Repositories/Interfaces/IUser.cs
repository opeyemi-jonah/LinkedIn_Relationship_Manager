using LinkedIn_Relationship_Manager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IUser : IDisposable
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByUserIdAsync(int id);
        Task<int> CreateUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(User user);
    }
}
