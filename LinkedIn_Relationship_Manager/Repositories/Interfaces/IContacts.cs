using LinkedIn_Relationship_Manager.Models;

namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface IContacts
    {
        Task<IEnumerable<User>> GetAllContactsAsync();
        Task<User> GetContactByContactId(int id);
        Task<int> CreateContactAsync(Contact contact);
        Task<bool> UpdateContactAsync(Contact contact);
        Task<bool> DeleteContactAsync(Contact contact);

    }
}
