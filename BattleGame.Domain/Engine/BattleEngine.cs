using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Domain.Contracts;
using BattleGame.Domain.Helpers;

namespace BattleGame.Domain.Engine
{
    public class BattleEngine
    {
        public static readonly BattleEngine Instance = new BattleEngine();
        private RoundActions _roundActions = new RoundActions();
        // A lot of the functionality in the battle engine perhaps must be accessed as private fields perhaps within the class, otherwise
        // it'll get bigger and violate srp perhaps...

        public void FullBattle(ICharacter hero, ICharacter monster)
        {
            while (hero.HitPoints >= 0 || monster.HitPoints >= 0)
            {
                battleRound(hero, monster);
            }
        }

        private void battleRound(ICharacter hero, ICharacter monster)
        {
            var heroAttackDamage = _roundActions.Attack(hero);
            var monsterAttackDamage = _roundActions.Attack(monster);
            
            monsterAttackDamage = _roundActions.Block(heroAttackDamage);
            heroAttackDamage = _roundActions.Block(monsterAttackDamage);

            DecrementStats.DecrementHealthPoints(hero, monsterAttackDamage);
            DecrementStats.DecrementHealthPoints(monster, heroAttackDamage);            
        }
    }
}
