using NUnit.Framework;
using NUnit.Framework.Legacy;
using UnitTestingLibrary;

namespace UnitTestingTests
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void TestAddition()
        {
            ClassicAssert.AreEqual(15, Basic.add(10, 5));
        }

        [Test]
        public void TestMultiplication()
        {
            ClassicAssert.AreEqual(50, Basic.mul(10, 5));
        }

        [Test]
        public void TestSubtraction()
        {
            ClassicAssert.AreEqual(5, Basic.sub(10, 5));
        }

        [Test]
        public void TestDivision()
        {
            ClassicAssert.AreEqual(2, Basic.div(10, 5));
        }
    }
}
