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
            BattleEngine.Instance.FullBattle(hero, monster);
        }

        [TestMethod]
        public void CanFightOneRound()
        {
            ICharacter hero = new Hero("Bob", 100, 100, 25);
            ICharacter monster = new Monster("Orc", 100, 20);

            BattleEngine.Instance.FullBattle(hero, monster);
            Assert.IsTrue(hero.HitPoints < 100);
            Assert.IsTrue(monster.HitPoints < 100);
        }

        [TestMethod]
        public void CanFightUntilOneCombatantHPisZeroOrBelow()
        {
            ICharacter hero = new Hero("Bob", 100, 100, 25);
            ICharacter monster = new Monster("Orc", 100, 20);

            BattleEngine.Instance.FullBattle(hero, monster);
            Assert.IsTrue(hero.HitPoints <= 0 || monster.HitPoints <= 0);
        }
    }
}
