using LinkedIn_Relationship_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkedIn_Relationship_Manager.DBContext
{
    public class DataContext : DbContext
    {
        // DbSet properties for each entity
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        // ... other DbSet properties
        public DbSet<LinkedInAccount> LinkedInAccounts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        public DbSet<ReminderContact> ReminderContacts { get; set; }


    // Constructor that takes DbContextOptions as a parameter
    public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        // Additional configuration and methods can be added here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<LinkedInAccount>().ToTable("LinkedInAccounts");
            modelBuilder.Entity<Message>().ToTable("Messages");
            modelBuilder.Entity<ReminderContact>().ToTable("ReminderContacts");
            modelBuilder.Entity<Reminder>().ToTable("Reminders");
        }
    }
}

