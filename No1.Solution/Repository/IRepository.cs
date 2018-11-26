namespace No1.Solution.Repository
{
    /// <summary>
    /// The interface of repository.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// The method that creates password in repository.
        /// </summary>
        /// <param name="password">
        /// The password to be created.
        /// </param>
        void Create(string password);
    }
}