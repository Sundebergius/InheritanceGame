using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public abstract class Weapons : Item
    {
        public Weapons(string title) : base(title)
        {
           
        }

        public abstract void Attack(IDamageable playerToAttack);
    }
}
