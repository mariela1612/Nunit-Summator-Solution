using NUnit.Framework;
using System;

namespace Summator.Tests
{
    [TestFixture]
    public class SummatorTests
    {
        private Summator summator;

        [SetUp]
        public void SetUp()
        {
            summator = new Summator();
            System.Console.WriteLine("Test started: " + DateTime.Now);
        }

       [Test]
       public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5, 7});

            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = summator.Sum(new int[] {  });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        [Category("Critical")]
        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });

            int expected = 6;

            Assert.That(expected == actual);
        }

        [TearDown]
        public void TearDown()
        {
            summator = null;
            System.Console.WriteLine("Test ended: " + DateTime.Now);
        }
    }
}