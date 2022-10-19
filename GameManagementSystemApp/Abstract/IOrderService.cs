using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Entity;
using GameManagementSystemApp.Concrete;

namespace GameManagementSystemApp.Abstract
{
    public interface IOrderService
    {
        void Order(Game game, Player player);
        void OrderWithCamp(Game game, Player player,Campaign campaign);
    }
}
