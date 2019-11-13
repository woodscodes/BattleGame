using System;
using BattleGame.Domain.Contracts;
using BattleGame.Domain.Entities;
using BattleGame.UI.Contracts;
using BattleGame.UI.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleGame.Tests.UITests
{
    [TestClass]
    public class DisplayingStats
    {
        [TestMethod]
        public void DisplayRoundStats()
        {
            ICharacter hero = new Hero("Bob", 100, 100, 50);
            ICharacter monster = new Monster("Orc", 100, 50);
            IDisplay statsDisplayer = new DisplayStats();

            Assert.IsTrue(!String.IsNullOrEmpty(statsDisplayer.Display(hero)));
            Assert.IsTrue(!String.IsNullOrEmpty(statsDisplayer.Display(monster)));
        }
    }
}
