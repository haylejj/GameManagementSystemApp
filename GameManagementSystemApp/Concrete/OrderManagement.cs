using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Abstract;
using GameManagementSystemApp.Entity;

namespace GameManagementSystemApp.Concrete
{
    public class OrderManagement : IOrderService
    {
        public void Order(Game game, Player player)
        {
            Console.WriteLine("{0} oyunu {1} oyuncusu tarafından {2} tl ye sipariş edildi.",game.Name,player.FullName,game.Price);
        }

        public void OrderWithCamp(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine("{0} oyunu {1} oyuncusu tarafından {2} indirimli olarak {3} tl ye  sipariş edildi.", game.Name, player.FullName, campaign.DiscountRate,game.Price);
        }
    }
}
