using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Helpers
{
    public class CharacterStatsPopulator : IPopulate
    {
        private Random _rand;

        public int GetBaseAttackDamage()
        {
            _rand = new Random();
            return _rand.Next(22, 31);
        }
    }
}
