using System.Collections.Generic;
using System.Linq;

namespace No1.Solution.Checker
{
    /// <summary>
    /// The class that checks password for validity.
    /// </summary>
    public class PasswordChecker : IPasswordChecker
    {
        private readonly IEnumerable<IPasswordChecker> _checkers;

        public PasswordChecker(IEnumerable<IPasswordChecker> checkers)
        {
            _checkers = checkers;
        }

        /// <summary>
        /// The method that checks the <paramref name="password"/> for validity.
        /// </summary>
        /// <param name="password">
        /// The password to be checked.
        /// </param>
        /// <returns>
        /// The tuple, whether password is okey and description string about it.
        /// </returns>
        public bool VerifyPassword(string password)
        {
            return _checkers.All(v => v.VerifyPassword(password));
        }
    }
}