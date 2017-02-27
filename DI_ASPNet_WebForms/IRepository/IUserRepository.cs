using DI_ASPNet_WebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_ASPNet_WebForms.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
