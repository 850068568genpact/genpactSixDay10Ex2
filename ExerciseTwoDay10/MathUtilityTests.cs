using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseTwoDayTen;

namespace ExerciseTwoDay10
{
    [TestFixture]
    internal class MathUtilityTests
    {
        [Test]
        public void AddTest()
        {
            MathUtility mathUtility = new MathUtility();
            int result = mathUtility.Add(5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void SubTest()
        {
            MathUtility mathUtility = new MathUtility();
            int result = mathUtility.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void MultiTest()
        {
            MathUtility mathUtility = new MathUtility();
            int result = mathUtility.Multiply(10, 5);
            Assert.AreEqual(50, result);
        }
        [Test]
        public void DivTest()
        {
            MathUtility mathUtility = new MathUtility();
            int result = mathUtility.Divide(10, 5);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void IsPrimeTest()
        {
            MathUtility mathUtility = new MathUtility();
            Assert.IsTrue(mathUtility.IsPrime(7));
        }
        [Test]
        public void DivideByZeroTest()
        {
            MathUtility mathUtility = new MathUtility();
            Assert.Throws<DivideByZeroException>(() => mathUtility.Divide(10, 0));
        }
    }
}
