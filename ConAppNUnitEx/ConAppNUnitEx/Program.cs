using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitEx
{
    internal class Program
    {
        public static string SignIn(string userName, string userPwd)
        {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
            {
                msg = "User Name and Password must not be null";
            }
            else
            {
                if (userName == "Sam" || userPwd == "Sammy")
                {
                    msg = "Sign Success!!";
                }
                else
                {
                    msg = "Inavlid Credentials";
                }
            }
            return msg;
        }
        static void Main(string[] args)
        {
        }
    }
}
