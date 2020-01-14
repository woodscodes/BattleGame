using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleGame.Domain.Contracts;

namespace BattleGame.Domain.Engine
{
    public class BattleEngine
    {
        //public static readonly BattleEngine Instance = new BattleEngine();        
        private ICharacter _hero;
        private ICharacter _monster;

        public BattleEngine(ICharacter hero, ICharacter monster)
        {
            _hero = hero;
            _monster = monster;
        }

        public void Fight()
        {
            while (_hero.HitPoints >= 0 && _monster.HitPoints >= 0)
            {
                _monster.HitPoints -= GetRoundDamage(_hero, _monster);
                _hero.HitPoints -= GetRoundDamage(_monster, _hero);
                RoundStatus(_hero, _monster);                
            }

            Console.WriteLine(DeclareWinner(_hero, _monster));      
        }
        
        private int GetRoundDamage(ICharacter attackingCharacter, ICharacter defendingCharacter)
        {
            var damage = attackingCharacter.PerformAttack();
            //damage = defendingCharacter.PerformBlock(damage);
            Console.WriteLine(RoundStats.ShowDamage(attackingCharacter.Name, damage));
            return damage;
        }

        private void RoundStatus(ICharacter hero, ICharacter monster)
        {
            Console.WriteLine($"{RoundStats.ShowStatus(hero)}\n{RoundStats.ShowStatus(monster)}");
            Console.WriteLine("\n");
        }

        private string DeclareWinner(ICharacter hero, ICharacter monster)
        {
            StringBuilder sb = new StringBuilder();

            if(hero.HitPoints > 0)
            {
                sb.Append($"{hero.Name} is victorious and has {hero.HitPoints}HP remaining");
                sb.Append("\n");
                sb.Append($"{monster.Name} has been vanquished");
            }
            else
            {
                sb.Append($"{monster.Name} is victorious and has {monster.HitPoints}HP remaining");
                sb.Append("\n");
                sb.Append($"{hero.Name} has been vanquished");
            }

            return sb.ToString();
            
        }
    }
}
