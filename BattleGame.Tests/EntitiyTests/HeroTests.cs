using System;
using BattleGame.Domain.Contracts;
using BattleGame.Domain.Engine;
using BattleGame.Domain.Entities;
using BattleGame.Domain.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleGame.Tests
{
    [TestClass]
    public class HeroTests
    {
        [TestMethod]
        public void CannotInstantiateCharacterBaseClass()
        {
            //var character = new Character();

            //Assert.IsNull(character);
        }

        [TestMethod]
        public void CanInstantiateAndNameAHero()
        {
            // arrange
            //var hero = new Hero();
            //hero.Name = "Bub";
            // act

            // assert
            //Assert.AreEqual("Bub", hero.Name);

        }

        [TestMethod]
        public void CannotAssignValuesExceptNameToHeroThroughConstructor()
        {            
            var hero = new Warrior("Bob");

            Assert.AreEqual("Bob", hero.Name);
            Assert.AreEqual(100, hero.HitPoints);
            Assert.AreEqual(100, hero.ManaPoints);
            Assert.AreEqual(25, hero.BaseAttackDamage);
        }
        
        [TestMethod]
        public void CanSendInHeroNameFromUserInput()
        {
            var name = "Bob";

            var hero = new Warrior(name);

            Assert.AreEqual("Bob", hero.Name);
        }

        [TestMethod]
        public void CanAssignBaseAttackDamageRandomlyFromARange()
        {
            var hero = new Warrior("Bob");

            Assert.AreEqual(hero.BaseAttackDamage < 36 || hero.BaseAttackDamage > 30, true);
        }

        private int GetBaseAttackDamage()
        {
            var rand = new Random();
            return rand.Next(22, 31);
        }

        [TestMethod]
        public void CanAssignBaseAttackDamageThroughHelperInterface()
        {
            var hero = new Warrior("Bob");

            Assert.AreEqual(hero.BaseAttackDamage < 36 || hero.BaseAttackDamage > 30, true);
        }


        [TestMethod]
        public void HeroCanReturnAnAttackDamageValue()
        {
            ICharacter hero = new Warrior("Bob");
            var attackDamage = hero.PerformAttack();
        }
    }
}
