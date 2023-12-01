
namespace LinkedIn_Relationship_Manager.Models
{
    public class User
    {
       public string Username { get; set; } = string.Empty;
        public string Firstname { get; set; } = string.Empty;
        public string? Lastname { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string UserId { get; } = new Guid().ToString();

       
    }
}
