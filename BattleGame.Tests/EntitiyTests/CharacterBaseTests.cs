using System;
using BattleGame.Domain.Entities;
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
    }
}
