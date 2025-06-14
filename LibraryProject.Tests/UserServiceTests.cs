// LibraryProject/Services/UserService.cs
using LibraryProject.Models;
using LibraryProject.Repositories;

namespace LibraryProject.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Registers a new user
        public void RegisterUser(User user)
        {
            if (_userRepository.GetUserByUsername(user.Username) != null)
            {
                throw new InvalidOperationException("User already exists.");
            }
            _userRepository.AddUser(user);
        }

        // Authenticates user by matching username and password
        public User AuthenticateUser(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (user != null && user.PasswordHash == password)
            {
                return user;  // Return user if authentication is successful
            }
            return null;  // Return null if authentication fails
        }
    }
}
