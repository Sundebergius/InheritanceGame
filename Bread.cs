using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Bread : Consumable
    {

        private int _restoredHitpoints;

        public int RestoredHitpoints
        {
            get
            {
                return _restoredHitpoints;
            }
        }

        public override void Consume(IHealable whoConsumesIt)
        {
            Console.WriteLine("I ate some bread. ");
        }

        public Bread(string title, int restoredHitpointAmount) : base(title)
        {
            _restoredHitpoints += restoredHitpointAmount;
        }
    }
}
