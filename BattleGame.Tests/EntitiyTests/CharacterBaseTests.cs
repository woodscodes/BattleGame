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
            var hero = new HeroSuperclass("Meh");

            Assert.IsNotNull(hero);
        }


        [TestMethod]
        public void CanAssignRandomValueToAttack()
        {
            ICharacter character = new HeroSuperclass("Blbdfd");
            //IRoundActions actions = new RoundActions(chanceActions);


            //var attackDamage = character.PerformAttack();
            //Assert.AreEqual(6, attackDamage);

        }

        [TestMethod]
        public void CanDecrementStatsBasedOnAttackDamage()
        {
            //IChanceActions chanceActions = new ChanceActions();
            ICharacter character = new HeroSuperclass("bsedrfsdf");
            //IRoundActions actions = new RoundActions(chanceActions);

            //var attackDamage = actions.Attack(character);
            //character = DecrementStats.DecrementHealthPoints(character, attackDamage);

            Assert.AreEqual(95, character.HitPoints);
        }

        [TestMethod]
        public void CanMitigateDamageBasedOnBlockValue()
        {
            //IChanceActions chanceActions = new ChanceActions();
            ICharacter character = new HeroSuperclass("vdisosdf");
            ICharacter character2 = new MonsterSuperclass();
            //IRoundActions actions = new RoundActions(chanceActions);

            //var attackDamage = actions.Attack(character);
            //var attackDamageAfterBlock = actions.Block(attackDamage);

            //Assert.AreEqual(6, attackDamageAfterBlock);
            //Assert.AreEqual(9, attackDamageAfterBlock);
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
