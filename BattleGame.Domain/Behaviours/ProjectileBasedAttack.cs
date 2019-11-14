﻿using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Behaviours
{
    public class ProjectileBasedAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Whoa a scary fireball");
        }
    }
}
