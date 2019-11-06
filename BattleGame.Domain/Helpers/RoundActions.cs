using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Helpers
{
    public class RoundActions : IActions
    {
        // singleton practice
        public static readonly RoundActions Instance = new RoundActions();
        private Random _rand;

        private RoundActions()
        {
            _rand = new Random();
        }

        public int Attack(ICharacter character)
        {
            // add in critical strike modifier?
            return _rand.Next(character.BaseAttackDamage, character.BaseAttackDamage + 1);
        }

        public int Block(int attackDamage)
        {
            var rollValue = _rand.Next(1, 13);
            return (int)Roll(rollValue, attackDamage);         
        }

        public void CastSpell()
        {
            throw new NotImplementedException();
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }

        private double Roll(int rollValue, int attackDamage)
        {
            if (rollValue == 12)
                return 0;
            else if (rollValue <= 11 && rollValue >= 8)
                return attackDamage * (1 - .40);
            else if (rollValue <= 7 && rollValue >= 4)
                return attackDamage * (1 - .20);
            else
                return attackDamage * (1 - .10);
        }
    }
}
