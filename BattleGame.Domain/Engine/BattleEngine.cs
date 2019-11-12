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
        public static readonly BattleEngine Instance = new BattleEngine();

        public void RoundStart(ICharacter hero, ICharacter monster)
        {

        }
    }
}
