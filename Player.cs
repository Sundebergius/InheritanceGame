using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player : IPlayer
    {
        private bool _isAlive;
        private int _hitpoints;
        private readonly Inventory _inventory;
        private string _agility;

        public bool IsAlive { get; set; }

        public int Hitpoints { get { return _hitpoints; } set { _hitpoints = value; } }

        public Player(int hitpoints, bool isAlive)
        {
            Hitpoints = hitpoints;
            _inventory = new Inventory();
            IsAlive = isAlive;
        }

        public Inventory Inventory { get { return _inventory; } }

        public void Die()
        {
            {
                Console.WriteLine("Your enemy died! ");
            }
        }

        public void DiePlus()
        {
            {
                Console.WriteLine("You can escape now... ");
            }
        }

        public void DiePlusPlus()
        {
            {
                Console.WriteLine("He is already dead, dude ! ");
            }
        }

        public void Heal(int amountHealed)
        {
            _hitpoints += amountHealed;
        }

        public void Respawn()
        {
            _hitpoints = 100;
            Console.WriteLine("Your severe beating worked as CPR, and your opponent is back at full health! ");
        }

        public int TakeDamage(int damagetaken)
        {
            Hitpoints -= damagetaken;
            return Hitpoints;
        }

        public override string? ToString()
        {
            return $"Player HP: {_hitpoints}";
        }
    }
}
