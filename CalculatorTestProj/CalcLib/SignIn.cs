using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CalcLib
{
    public class SignIn
    {
        public static string SignInCheck(string userName, string userPwd)
        {
            string msg = "";
            //if(userName == null || userPwd == null)
            //{
            //    msg = "Please provide User Name and Password";
            //}
            if (string.IsNullOrEmpty(userName)||string.IsNullOrEmpty(userPwd))
            {
                msg = "Please provide User Name and Password";
            }
            else
            {
                if ((userName == "Sam") && (userPwd == "Sammy"))
                {
                    msg = "SignIn Success";
                }
                else
                {
                    msg = "Invalid Credentials";
                }
            }
            return msg;
        }
    }
}
