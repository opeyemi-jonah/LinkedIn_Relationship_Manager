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

            modelBuilder.Entity<ReminderContact>().HasOne(usr => usr.User).WithMany(rc => rc.ReminderContacts).HasForeignKey(usr => usr.UserId);
            modelBuilder.Entity<ReminderContact>().HasOne(usr => usr.Contact).WithMany(rc => rc.ReminderContacts).HasForeignKey(usr => usr.ContactId);
            modelBuilder.Entity<ReminderContact>().HasOne(usr => usr.Reminder).WithMany(rc => rc.ReminderContacts).HasForeignKey(usr => usr.ReminderId).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}

