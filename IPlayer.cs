using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
   public interface IPlayer : IDamageable, IHealable
    {
        bool IsAlive { get; set; }

        int Hitpoints { get; set; }

        Inventory Inventory { get; }

        void Die();

        void DiePlus();

        void DiePlusPlus();

        void Respawn();
    }
}
