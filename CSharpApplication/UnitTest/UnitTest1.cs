using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCaseWithNegatifRadius()
        {

            CSharpApplication.Shape circle1 = new CSharpApplication.Circle(-2);

        }

        [TestMethod]
        public void TestcaseWithPositifRadius()
        {
            CSharpApplication.Circle circle1 = new CSharpApplication.Circle(2);
            int expected = 2;
            int actual = circle1.getRadius();
   
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCaseWithNegatifEdge()
        {

            CSharpApplication.Shape triangle1 = new CSharpApplication.Triangle(1, -2, 3);

        }
        [TestMethod]
        public void TestcaseWithPositifEdge()
        {
            CSharpApplication.Triangle triangle1 = new CSharpApplication.Triangle(4, 5, 6);


            Assert.AreEqual(4, triangle1.getA());
            Assert.AreEqual(5, triangle1.getB());
            Assert.AreEqual(6, triangle1.getC());
        }

       
    }
}
