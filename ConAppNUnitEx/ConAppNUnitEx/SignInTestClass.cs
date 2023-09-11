using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitEx
{
    [TestFixture]
    public class SignInTestClass
    {
        [Test]
        public void SignInTest()
        {
            string empResult= "User Name and Password must not be null";
            string failResult= "Inavlid Credentials";
            string sResult= "Sign Success!!";
            Assert.AreEqual(empResult, Program.SignIn(null, null));
            Assert.AreEqual(empResult, Program.SignIn("", ""));
            Assert.AreEqual(failResult, Program.SignIn("Ravi", "Raavi"));
            Assert.AreEqual(sResult, Program.SignIn("Sam", "Sammy"));
        }
    }
}
