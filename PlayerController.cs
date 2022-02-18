using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class PlayerController
    {
        IPlayer player;

        public PlayerController()
        {
            player = new Player(100, true);
        }

        public void useItem(Item item)
        {
            Consumable consumable = (Consumable)item;
            consumable.Consume(player);
            
            player.Inventory.UseFromInventory(item);
        }
    }
}
