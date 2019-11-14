using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Behaviours
{
    public class UnarmouredBlock : IDefend
    {
        public void Block()
        {
            Console.WriteLine("Tis but a scracth");
        }
    }
}
