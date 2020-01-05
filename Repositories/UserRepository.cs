using System.Collections.Generic;
using System.Linq;
using Eshop.Models;

namespace Eshop.Repositories
{
    public static class UserRepository
    {
        public static User GetUser(string name, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Name = "batman", Email = "batman@email.com", Password = "123456", Role = "manager" });
            users.Add(new User { Id = 1, Name = "robin", Email = "robin@email.com", Password = "123456", Role = "employee" });

            return users.Where(x => x.Name.ToLower() == name.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}