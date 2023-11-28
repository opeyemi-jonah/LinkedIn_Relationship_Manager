namespace LinkedIn_Relationship_Manager.Interfaces
{
    public interface IUser
    {
        Guid UserId { get; }
        string Username { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}
