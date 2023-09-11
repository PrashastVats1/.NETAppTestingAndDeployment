using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestMockingEx
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EqualTest()
        {
            int num1 = 15;
            Assert.AreEqual(15,num1);
        }
        [TestMethod]
        public void MockTestExample()
        {
            //Mock<CheckEmp> chk = new Mock<CheckEmp>();
            //chk.Setup(x => x.checkEmp()).Returns(true);
            //Problem
            //CheckEmp chk = new CheckEmp();
            //ProcessEmployee process = new ProcessEmployee();
            //Assert.AreEqual(true,process.InsertEmp(chk));

            //Solution
            Mock<CheckEmp> chk = new Mock<CheckEmp>();
            chk.Setup(x => x.checkEmp()).Returns(true);
            ProcessEmployee process = new ProcessEmployee();
            Assert.AreEqual(true, process.InsertEmp(chk.Object));
        }
    }
}
