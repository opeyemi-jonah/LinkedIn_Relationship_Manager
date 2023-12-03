using LinkedIn_Relationship_Manager.DBContext;
using LinkedIn_Relationship_Manager.Models;

using System;
using System.Linq;

namespace LinkedIn_Relationship_Manager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext dataContext)
        {
            dataContext.Database.EnsureCreated();

            //Look for any users.
            if (dataContext.Users.Any())
            {
                return; //DB has been seeded
            }

            var users = new User[]
            {
                new User{ Username = "opeyemi-jonah",Firstname = "Opeyemi", Lastname = "Jonah", Email = "gavrieljonah@gmail.com", PhoneNumber = "5055552222" },
                new User{ Username = "king-james",Firstname = "Lebron", Lastname = "James", Email = "lbj@gmail.com", PhoneNumber = "5055551111" },
                new User{ Username = "DFoxx",Firstname = "DeAndre", Lastname = "Foxx", Email = "dfoxx@gmail.com", PhoneNumber = "5055550000" },
                new User{ Username = "AzCarey",Firstname = "Azurie", Lastname = "Carey", Email = "Azurie@gmail.com", PhoneNumber = "9095550000" },

            };
            foreach (User u in users)
            {
                dataContext.Users.Add(u);
            }
            dataContext.SaveChanges();

            //Seed Contacts
            if (dataContext.Contacts.Any())
            {
                return; //DB has been seeded.
            }

            var contacts = new Contact[]
            {
                new Contact{Firstname="Joey", Lastname = "Sheen", Company = "Microsoft", Email="jsheen@microsoft.com", JobDescription="Makes good software look amazing", JobTitle="Software Engineer", ProfileLink="https://www.linkedin.com/in/opeyemi-jonah/"}
                new Contact{Firstname="Darman", Lastname = "Rah", Company = "Google", Email="dman@google.com", JobDescription="Testing new features and deployment to production", JobTitle="QA Engineer", ProfileLink="https://www.linkedin.com/in/opeyemi-jonah/"}
                new Contact{Firstname="Sandra", Lastname = "Lewiski", Company = "Go Go Gadgets", Email="sandraLewiski@gogogadgets.com", JobDescription="Customer outreach and sales operations analyst", JobTitle="Sales Manager", ProfileLink="https://www.linkedin.com/in/opeyemi-jonah/"}
            };
            foreach(Contact contact in contacts)
            {
                dataContext.Contacts.Add(contact);
            }
            dataContext.SaveChanges();
        }
    }
}
