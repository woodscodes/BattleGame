using System;
using BattleGame.Domain.Contracts;
using BattleGame.Domain.Engine;
using BattleGame.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleGame.Tests.BattleEngineTests
{
    [TestClass]
    public class RoundTests
    {
        [TestMethod]
        public void CanCreateABattleEngineInstance()
        {
            ICharacter hero = new Hero("Bob", 100, 100, 25);
            ICharacter monster = new Monster("Orc", 100, 20);
            BattleEngine.Instance.RoundStart(hero, monster);
        }
    }
}
