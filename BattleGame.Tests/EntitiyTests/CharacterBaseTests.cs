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
            var character = new Character("Meh", 100, 100, 25);

            Assert.IsNotNull(character);
        }

        [TestMethod]
        public void CanDecrementHpOfCharacterUsingInterface()
        {
            ICharacter hero = new Character("Meh", 100, 100, 25);
            IDecrementStats calculate = new DecrementStats();
            hero = calculate.DecrementHealthPoints(hero, 0);

            Assert.AreEqual(99, hero.HitPoints);
        }

        [TestMethod]
        public void CanAssignRandomValueToAttack()
        {
            ICharacter character = new Character("Blbdfd", 100, 100, 5);
            IActions actions = RoundActions.Instance;


            var attackDamage = actions.Attack(character);
            Assert.AreEqual(6, attackDamage);

        }

        [TestMethod]
        public void CanDecrementStatsBasedOnAttackDamage()
        {
            ICharacter character = new Character("bsedrfsdf", 100, 100, 5);
            IDecrementStats decrementer = new DecrementStats();
            IActions actions = RoundActions.Instance;

            var attackDamage = actions.Attack(character);
            character = decrementer.DecrementHealthPoints(character, attackDamage);

            Assert.AreEqual(95, character.HitPoints);
        }

        [TestMethod]
        public void CanMitigateDamageBasedOnBlockValue()
        {
            ICharacter character = new Character("vdisosdf", 100, 100, 20);
            ICharacter character2 = new Character("monster", 100, 100, 10);
            IActions actions = RoundActions.Instance;

            var attackDamage = actions.Attack(character);
            var attackDamageAfterBlock = actions.Block(attackDamage);

            Assert.AreEqual(6, attackDamageAfterBlock);
            Assert.AreEqual(9, attackDamageAfterBlock);
        }

        [TestMethod]
        public void PercentBasedBlockMitigation()
        {
            var attackDamage = 20;
            var attackDamageAfterBlock = attackDamage * (1 - .25);

            Assert.AreEqual(15, attackDamageAfterBlock);
        }


        
    }
}
