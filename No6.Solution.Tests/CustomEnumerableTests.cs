using System;
using System.Linq;
using System.Numerics;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            CollectionAssert.AreEqual(expected, SequanceGenerator<int>.GenerateSequance(1, 1, (a, b) => a + b, 10));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] generated = SequanceGenerator<int>.GenerateSequance(1, 2, (a, b) => 6 * b - 8 * a, 10).ToArray();
            CollectionAssert.AreEqual(expected, generated);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            double[] generated = SequanceGenerator<double>.GenerateSequance(1, 2, (a, b) => a / b + b, 10).ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], generated[i], 1e-10);
            }
        }
    }
}
