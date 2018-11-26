using No1.Solution.Checker;
using No1.Solution.Repository;

namespace No1.Solution
{
    /// <summary>
    /// The class of password service
    /// </summary>
    public class PasswordCheckerService
    {
        private readonly IPasswordChecker _checker;

        private readonly IRepository _repository;

        /// <summary>
        /// The ctor.
        /// </summary>
        /// <param name="checker">
        /// The checker of the password.
        /// </param>
        /// <param name="repository">
        /// The repository to store passwords.
        /// </param>
        public PasswordCheckerService(IPasswordChecker checker, IRepository repository)
        {
            _checker = checker;
            _repository = repository;
        }

        /// <summary>
        /// The method that adds <paramref name="password"/> to <see cref="IRepository"/>
        /// </summary>
        /// <param name="password">
        /// The password to be created.
        /// </param>
        public bool Add(string password)
        {
            bool verified = _checker.VerifyPassword(password);
            if (verified)
            {
                _repository.Create(password);
            }

            return verified;
        }
    }
}