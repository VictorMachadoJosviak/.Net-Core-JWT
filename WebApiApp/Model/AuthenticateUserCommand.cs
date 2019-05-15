using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApp.Model
{
    public class AuthenticateUserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
