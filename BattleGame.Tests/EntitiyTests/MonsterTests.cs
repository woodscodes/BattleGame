using System;
using BattleGame.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleGame.Tests
{
    [TestClass]
    public class MonsterTests
    {
        [TestMethod]
        public void CanInstantiateMonsterAndAddValues()
        {
            var monster = new Monster("Orc", 100, 25);

            Assert.IsNotNull(monster);
            Assert.AreEqual("Orc", monster.Name);
            Assert.AreEqual(100, monster.HitPoints);
            Assert.AreEqual(25, monster.BaseAttackDamage);
        }

        [TestMethod]
        public void CanModifyValuesOfMonster()
        {
            var monster = new Monster("Orc", 100, 25);
            //monster.Name = "Bob";
            monster.ManaPoints = 0;

            Assert.AreNotEqual("Bob", monster.Name);
        }
    }
}
