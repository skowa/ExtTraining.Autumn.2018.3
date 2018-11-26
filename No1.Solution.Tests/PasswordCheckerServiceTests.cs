using System.Collections.Generic;
using No1.Solution.Checker;
using No1.Solution.Repository;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void AddTest()
        {
            IPasswordChecker[] checkers = {new LetterPasswordChecker(), new BigLengthPasswordChecker(), new DigitPasswordChecker(), new EmptyPasswordChecker()};
            PasswordCheckerService service = new PasswordCheckerService(new PasswordChecker(checkers), new SqlRepository());

            Assert.IsTrue(service.Add("a12345678"));
        }

        [Test]
        public void AddTest_PasswordIsNotAdded()
        {
            IPasswordChecker[] checkers = { new LetterPasswordChecker(), new LilttleLengthPasswordChecker(), new DigitPasswordChecker(), new EmptyPasswordChecker() };

            PasswordCheckerService service = new PasswordCheckerService(new PasswordChecker(checkers), new SqlRepository());

            Assert.IsFalse(service.Add("a125678"));
        }

        [Test]
        public void AddTest_OtherChecker()
        {
            PasswordCheckerService service = new PasswordCheckerService(new Checker(), new SqlRepository());

            Assert.IsTrue(service.Add("a12345678"));
        }

        [Test]
        public void AddTest_OtherChecker_IsMotAdded()
        {
            PasswordCheckerService service = new PasswordCheckerService(new Checker(), new SqlRepository());

            Assert.IsFalse(service.Add("12345678"));
        }

        private class Checker : IPasswordChecker
        {
            public bool VerifyPassword(string password)
            {
                return (password.IndexOf('a') != -1);
            }
        }
    }
}