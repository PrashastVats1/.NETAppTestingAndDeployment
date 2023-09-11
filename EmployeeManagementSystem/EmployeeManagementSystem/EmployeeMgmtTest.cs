using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [TestFixture]
    public class EmployeeMgmtTest
    {
        Program obj;
        List<Employee> list;
        [Test]
        public void NotNullTest()
        {
            obj=new Program();
            list = obj.AllEmployees();
            foreach(var item in list)
            {
                Assert.IsNotNull(item.Id);
                Assert.IsNotNull(item.Name);
                Assert.IsNotNull(item.Designation);
                Assert.IsNotNull(item.Salary);
                Assert.IsNotNull(item.Doj);
            }
        }
        [Test]
        public void EmpDetailsTest()
        {
            int id = 3;
            string name = "Aniket";
            double salary = 685000.50;
            string designation = "Tester";
            DateTime doj = new DateTime(day: 24, month: 02, year: 2023);
            obj = new Program();
            Employee emp = obj.EmpDetails(id);
            Assert.AreEqual(name, emp.Name);
            Assert.AreEqual(salary, emp.Salary);
            Assert.AreEqual(designation, emp.Designation);
            Assert.AreEqual(doj, emp.Doj);
        }
    }
}
