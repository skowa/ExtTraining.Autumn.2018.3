using System;

namespace No1.Solution.Checker
{
    public class BigLengthPasswordChecker : IPasswordChecker
    {
        public bool VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }

            return (password.Length < 15);
        }
    }
}