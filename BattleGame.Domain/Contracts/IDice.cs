using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Contracts
{
    public interface IDice
    {
        int Roll();
        int Roll(int lowerBound, int upperBound);
    }
}
