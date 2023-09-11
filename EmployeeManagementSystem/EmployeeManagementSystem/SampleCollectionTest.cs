using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [TestFixture]
    public class SampleCollectionTest
    {
        List<string> majorColors = new List<string> { "fuschisa","indigo","red", "white", "pink", "blue", "green","yellow" };
        List<string> colors = new List<string> { "red", "white", "pink", "blue", "green" };
        [Test]
        public void ContainsTest()
        {
            Assert.That(colors.Contains("red"), Is.True);
            Assert.That(colors, Has.Member("red"));
        }
        [Test]
        public void NotContainsTest()
        {
            Assert.That(colors, Has.No.Member("indigo"));
        }
        [Test]
        public void SuperSetTest()
        {
            Assert.That(majorColors, Is.SupersetOf(colors));
        }
        [Test]
        public void SubSetTest()
        {
            Assert.That(colors, Is.SubsetOf(majorColors));
        }
    }
}
