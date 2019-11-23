using NUnit.Framework;
using testci;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(testci.TestMe.Summ(3, 6), 9);
        }


        [Test]
        public void Test2()
        {
            Assert.AreEqual(testci.TestMe.Summ(-4, 4), 0);
        }
    }
}