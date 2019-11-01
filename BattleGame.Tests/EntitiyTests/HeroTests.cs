using System;
using BattleGame.Domain.Contracts;
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
        public void CanAssignValuesToHeroThroughConstructor()
        {            
            var hero = new Hero("Bob", 100, 100, 25);

            Assert.AreEqual("Bob", hero.Name);
            Assert.AreEqual(100, hero.HitPoints);
            Assert.AreEqual(100, hero.ManaPoints);
            Assert.AreEqual(25, hero.BaseAttackDamage);
        }
        
        [TestMethod]
        public void CanSendInHeroNameFromUserInput()
        {
            var name = "Bob";

            var hero = new Hero(name, 100, 100, 25);

            Assert.AreEqual("Bob", hero.Name);
        }

        [TestMethod]
        public void CanAssignBaseAttackDamageRandomlyFromARange()
        {
            var hero = new Hero("Bob", 100, 100, GetBaseAttackDamage());

            Assert.AreEqual(hero.BaseAttackDamage < 31 || hero.BaseAttackDamage > 22, true);
        }

        private int GetBaseAttackDamage()
        {
            var rand = new Random();
            return rand.Next(22, 31);
        }

        [TestMethod]
        public void CanAssignBaseAttackDamageThroughHelperInterface()
        {
            int damage = 50;
            var hero = new Hero("Bob", 100, 100, damage);

            Assert.AreEqual(hero.BaseAttackDamage < 31 || hero.BaseAttackDamage > 22, true);
        }

        [TestMethod]
        public void HeroCanCreateAnIntegerValueRepresentingRoundsAttackDamage()
        {
            ICharacter hero = new Hero("Meh", 100, 100, 25);
            ICharacter monster = new Monster("Bob", 100, 44);

            var heroAttackDamage = hero.Attack();

            Assert.AreEqual(26, heroAttackDamage);
        }
    }
}
