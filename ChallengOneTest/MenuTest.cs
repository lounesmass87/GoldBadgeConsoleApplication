
using ChallengeOne.POCO;
using ChallengeOne.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengOneTest
{
    [TestClass]
    public class MenuTest
    {
        private static MenuRepo _MenuRepo = new MenuRepo();
        [TestMethod]
        public void RemoveMenu()
        {
            //Arrange
            Menu Items = new Menu("test", "user", false);
            bool expected = true;
            //Act
            bool actuel = _MenuRepo.CreatMenu(menu);
            //Assert
            Assert.AreEqual

        }
        [TestClass]
        public class MyTestClass
        {

        }
    }
}
