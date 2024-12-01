using NUnit.Framework;
using NUnit.Framework.Legacy;
using Homework1;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void PassingTest()
        {
            ClassicAssert.AreEqual(4, Calculator.Add(2,2));
        }

        [Test]
        public void FailingTest()
        {
            ClassicAssert.AreEqual(4, Calculator.Add(2,2));
        }
    }
}