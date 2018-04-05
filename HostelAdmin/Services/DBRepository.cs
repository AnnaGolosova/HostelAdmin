using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelAdmin.Services
{
    public class DBRepository
    {
        public static LoginState Login(string login, string password)
        {
            try
            {
                if (login.CompareTo("admin") != 0)
                    return LoginState.WrongEmail;
                else if (password.CompareTo("admin") != 0)
                    return LoginState.WrongPassword;
                else return LoginState.Success;
            }
            catch(Exception)
            {
                return LoginState.ConnectionError;
            }
        }
    }
}
