using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Contracts
{
    public interface ICharacter
    {
        string Name { get; }
        int HitPoints { get; set; }
        int ManaPoints { get; set; }
        int BaseAttackDamage { get; }
    }
}
