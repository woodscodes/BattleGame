﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Contracts
{
    public interface IDefensiveActions
    {
        int Block(int attackDamage);
    }
}
