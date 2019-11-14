using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Behaviours
{
    public class WeaponBasedAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Cut you");
        }
    }
}
