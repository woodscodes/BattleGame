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
            var be = new BattleEngine(new Warrior("Bob"), new Orc());
            be.Fight();           
        }
    }
}
