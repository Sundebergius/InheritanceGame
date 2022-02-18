using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public abstract class Consumable : Item
    {
        public Consumable(string title) : base(title)
        {

        }

        public abstract void Consume(IHealable whoConsumesIt);
    }
}
