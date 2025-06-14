// LibraryProject/Models/User.cs
namespace LibraryProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Initialize with an empty string
        public string PasswordHash { get; set; } = string.Empty; // Initialize with an empty string
        public string Role { get; set; } = string.Empty; // Initialize with an empty string
    }
}
