using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Katana : Weapons
    {
        private int _damageDealt;
        public Katana(string title, int damageDealt) : base(title)
        {
            _damageDealt = damageDealt;
        }

        public int DamageTaken { get { return _damageDealt; } }

        public override void Attack(IDamageable playerToAttack)
        {
            playerToAttack.TakeDamage(DamageTaken);
        }
    }
}
