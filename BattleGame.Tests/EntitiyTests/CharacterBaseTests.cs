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
            hero = DecrementStats.DecrementHealthPoints(hero, 1);

            Assert.AreEqual(99, hero.HitPoints);
        }

        [TestMethod]
        public void CanAssignRandomValueToAttack()
        {
            IChanceActions chanceActions = new ChanceActions();
            ICharacter character = new Character("Blbdfd", 100, 100, 5);
            IRoundActions actions = new RoundActions(chanceActions);


            var attackDamage = actions.Attack(character);
            Assert.AreEqual(6, attackDamage);

        }

        [TestMethod]
        public void CanDecrementStatsBasedOnAttackDamage()
        {
            IChanceActions chanceActions = new ChanceActions();
            ICharacter character = new Character("bsedrfsdf", 100, 100, 5);
            IRoundActions actions = new RoundActions(chanceActions);

            var attackDamage = actions.Attack(character);
            character = DecrementStats.DecrementHealthPoints(character, attackDamage);

            Assert.AreEqual(95, character.HitPoints);
        }

        [TestMethod]
        public void CanMitigateDamageBasedOnBlockValue()
        {
            IChanceActions chanceActions = new ChanceActions();
            ICharacter character = new Character("vdisosdf", 100, 100, 20);
            ICharacter character2 = new Character("monster", 100, 100, 10);
            IRoundActions actions = new RoundActions(chanceActions);

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
