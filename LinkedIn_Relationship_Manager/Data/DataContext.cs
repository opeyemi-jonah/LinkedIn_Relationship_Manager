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

            modelBuilder.Entity<ReminderContact>().HasKey(rc => new
            {
                rc.ReminderId,
                rc.UserId,
                rc.ContactId
            });

            modelBuilder.Entity<ReminderContact>()
            .HasOne(rc => rc.User)
            .WithMany(u => u.ReminderContacts)
            .HasForeignKey(rc => rc.UserId);

            modelBuilder.Entity<ReminderContact>()
                .HasOne(rc => rc.Contact)
                .WithMany(c => c.ReminderContacts)
                .HasForeignKey(rc => rc.ContactId);

            modelBuilder.Entity<ReminderContact>()
                .HasOne(rc => rc.Reminder)
                .WithMany(r => r.ReminderContacts)
                .HasForeignKey(rc => rc.ReminderId).OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(modelBuilder);
        }
    }
}

