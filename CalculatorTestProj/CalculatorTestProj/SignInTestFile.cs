using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;

namespace CalculatorTestProj
{
    public class SignInTestFile
    {
        [Fact]
        public void SignInTest()
        {
            string result = "Invalid Credential";
            string userName = "amit";
            string userPwd = "staramit";
            Assert.Equal(result, SignIn.SignInCheck(userName, userPwd));
        }
    }
}
