namespace No1.Solution.Checker
{
    /// <summary>
    /// The password checker interface
    /// </summary>
    public interface IPasswordChecker
    {
        /// <summary>
        /// The method that checks the <paramref name="password"/> for validity.
        /// </summary>
        /// <param name="password">
        /// The password to be checked.
        /// </param>
        /// <returns>
        /// Whether password is okey.
        /// </returns>
        bool VerifyPassword(string password);
    }
}