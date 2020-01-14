using BattleGame.Domain.Contracts;
using BattleGame.Domain.Engine;
using BattleGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var be = new BattleEngine(new Warrior("Bob"), new Orc());
            be.Fight();
        }
    }
}
