using DI_ASPNet_WebForms.IRepository;
using DI_ASPNet_WebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI_ASPNet_WebForms.Repository
{
    public class UserRepository : IUserRepository
    {
        IList<User> userList = new List<User>();
        public UserRepository()
        {
            User user = new User
            {
                Email = "jimcute8879@gmail.com",
                FirstName = "Jameer",
                LastName = "Khan"
            };
            userList.Add(user);
        }
        public IEnumerable<Model.User> GetUsers()
        {
            return userList;
        }
    }
}