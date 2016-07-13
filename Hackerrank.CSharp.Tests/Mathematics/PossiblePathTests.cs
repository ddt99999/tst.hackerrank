using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackerrank.CSharp.Mathematics;

namespace Hackerrank.CSharp.Tests.Mathematics
{
    [TestClass]
    public class PossiblePathTests
    {
        [TestMethod]
        public void TestGCD()
        {
            var gcd = PossiblePath.ComputeGreatCommonDivisor(100, 35);
            Assert.AreEqual(5, gcd);

            gcd = PossiblePath.ComputeGreatCommonDivisor(18, 15);
            Assert.AreEqual(3, gcd);

            gcd = PossiblePath.ComputeGreatCommonDivisor(15, 18);
            Assert.AreEqual(3, gcd);
        }

        [TestMethod]
        public void TestRecursiveGCD()
        {
            var gcd = PossiblePath.ComputeGreatCommonDivisorRec(100, 35);
            Assert.AreEqual(5, gcd);

            gcd = PossiblePath.ComputeGreatCommonDivisorRec(18, 15);
            Assert.AreEqual(3, gcd);

            gcd = PossiblePath.ComputeGreatCommonDivisorRec(15, 18);
            Assert.AreEqual(3, gcd);
        }
    }
}
