using Apps.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Core.Models;


namespace Apps.Core.Contracts
{
    public interface IAuthService
    {
        User Register(User user, string password);
        User Login(string email, string password);
        bool UserExists(string email);
    }
}
