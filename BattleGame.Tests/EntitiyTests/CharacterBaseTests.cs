using System;
using BattleGame.Domain.Contracts;
using BattleGame.Domain.Engine;
using BattleGame.Domain.Entities;
using BattleGame.Domain.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleGame.Tests
{
    [TestClass]
    public class CharacterBaseTests
    {
        [TestMethod]
        public void CanInstantiateACharacterFromConstructor()
        {
            var character = new Character("Meh", 100, 25);

            Assert.IsNotNull(character);
        }

        [TestMethod]
        public void CanDecrementHpOfCharacterUsingInterface()
        {
            ICharacter hero = new Character("Meh", 100, 25);
            IDecrementStats calculate = new DecrementStats();
            hero = calculate.DecrementHealthPoints(hero, 0);

            Assert.AreEqual(99, hero.HitPoints);
        }

        [TestMethod]
        public void CanAssignRandomValueToAttack()
        {
            ICharacter character = new Character("Blbdfd", 100, 5);

            var attackDamage = character.Attack();
            Assert.AreEqual(6, attackDamage);

        }

        [TestMethod]
        public void CanDecrementStatsBasedOnAttackDamage()
        {
            ICharacter character = new Character("bsedrfsdf", 100, 5);
            IDecrementStats decrementer = new DecrementStats();

            var attackDamage = character.Attack();
            character = decrementer.DecrementHealthPoints(character, attackDamage);

            Assert.AreEqual(95, character.HitPoints);
        }


        
    }
}
