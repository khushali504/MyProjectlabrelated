// LibraryProject/Repositories/UserRepository.cs
using LibraryProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject.Repositories
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public User GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);
        public User GetUserByUsername(string username) => _users.FirstOrDefault(u => u.Username == username);
        public void AddUser(User user) => _users.Add(user);
    }
}
