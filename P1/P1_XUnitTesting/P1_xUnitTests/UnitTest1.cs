using System;
using Xunit;
using P1;
using P1.Models;

namespace P1_xUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void UserAccountExists_ReturnsFalse()
        {
            UserAccount account = new UserAccount
            {
                Username = "fail",
                Password = "fail"
            };
            bool exists = DatabaseControl.AccountExists(account);

            Assert.False(exists);
        }

        [Fact]
        public void UserAccountExists_ReturnsTrue()
        {
            UserAccount account = new UserAccount
            {
                Username = "kmora",
                Password = "data"
            };
            bool exists = DatabaseControl.AccountExists(account);

            Assert.True(exists);
        }
    }
}
