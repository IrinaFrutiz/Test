using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestMethod
    {
        [TestMethod]
        public void TestMethodSquare()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.Size, 5);
            Assert.AreEqual(s2.Size, 10);
            Assert.AreEqual(s3.Size, 5);

            s3.Size = 15;
            Assert.AreEqual(s1.Size, 15);

            s2.Colored = true;
        }

        [TestMethod]
        public void TestMethodCircle()
        {
            Circle s1 = new Circle(5);
            Circle s2 = new Circle(10);
            Circle s3 = s1;

            Assert.AreEqual(s1.Rad, 5);
            Assert.AreEqual(s2.Rad, 10);
            Assert.AreEqual(s3.Rad, 5);

            s3.Rad = 15;
            Assert.AreEqual(s1.Rad, 15);

            s2.Colored = true;
        }
    }
}
