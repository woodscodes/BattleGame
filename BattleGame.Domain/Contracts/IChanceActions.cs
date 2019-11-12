using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Contracts
{
    public interface IChanceActions
    {
        double RollForAttackDamage(int baseAttackDamage);
        double RollForBlock(int damageRecieved);        
    }
}
