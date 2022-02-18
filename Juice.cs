using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Juice : Consumable
    {
        private int _restoresHitpointAmount;

        public int RestoredHitpoints
        {
            get { return _restoresHitpointAmount; }
        }

        public override void Consume(IHealable whoConsumesIt)
        {
            Console.WriteLine("I drank some juice. ");
            
        }

        public Juice(string title, int restoredHitpointAmount) : base(title)
        {
            _restoresHitpointAmount = restoredHitpointAmount;
        }
    }
}
