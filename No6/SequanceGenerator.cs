using System;
using System.Collections.Generic;

namespace No6
{
    /// <summary>
    /// The class of sequence generator.
    /// </summary>
    /// <typeparam name="T">
    /// The type of elements in sequence to be generated.
    /// </typeparam>
    public static class SequanceGenerator<T>
    {
        /// <summary>
        /// The method that generates sequence according to the rule.
        /// </summary>
        /// <param name="first">
        /// The first element.
        /// </param>
        /// <param name="second">
        /// The second element.
        /// </param>
        /// <param name="rule">
        /// The rule of generation of the next elements.
        /// </param>
        /// <param name="amount">
        /// The amount of elements to be generated.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="amount"/> is not positive.
        /// </exception>
        /// <returns>
        /// The generated sequence.
        /// </returns>
        public static IEnumerable<T> GenerateSequance(T first, T second, Func<T, T, T> rule, int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException($"{nameof(amount)} should be positive!");
            }

            return GetSequence();

            IEnumerable<T> GetSequence()
            {
                yield return first;
                yield return second;

                for (int i = 2; i < amount; i++)
                {
                    T third = rule(first, second);
                    first = second;
                    second = third;

                    yield return third;
                }
            }
        }
    }
}