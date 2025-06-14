using WebApiProject.Models;

namespace WebApiProject.Services
{
    public class UserService
    {
        private static List<User> _users = new List<User>(); // In-memory list to simulate a database

        // Register a new user
        public User RegisterUser(string username, string password)
        {
            var user = new User(username, password);
            _users.Add(user);
            return user;
        }

        // Authenticate the user
        public User AuthenticateUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
        }
    }
}
