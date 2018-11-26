using System;
using System.Linq;

namespace No1.Solution.Checker
{
    public class LetterPasswordChecker : IPasswordChecker
    {
        public bool VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }

            return (password.Any(char.IsLetter)) ;
        }
    }
}