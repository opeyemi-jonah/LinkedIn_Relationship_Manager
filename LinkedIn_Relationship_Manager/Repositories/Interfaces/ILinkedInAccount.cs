using System;

namespace LinkedIn_Relationship_Manager.Repositories.Interfaces
{
    public interface ILinkedInAccount
    {
        void GetLinkedInAccountById(int id);
        void GetLinkedInAccountByUserId(int userId);

        void GetLinkedInAccountByEmail(string email);

    }
}
