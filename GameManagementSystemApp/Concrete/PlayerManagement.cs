using GameManagementSystemApp.Abstract;
using GameManagementSystemApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementSystemApp.Concrete
{
    public class PlayerManagement : IPlayer
    {
         IPlayerCheckService _checkService;

        public PlayerManagement(IPlayerCheckService checkService)
        {
            _checkService=checkService;
        }

        public void Delete(Player player)
        {
            Console.WriteLine("{0} ismindeki oyuncu Silindi.", player.FullName);
        }

        public void SignUp(Player player)
        {
            if (_checkService.CheckPlayer(player))
            {
                Console.WriteLine("{0} ismindeki oyuncu kaydoldu.",player.FullName);
            }
            else
            {
                throw new Exception("NOT A VALİD PERSON");
            }
        }

       

        public void Update(Player player)
        {
            Console.WriteLine("{0} ismindeki oyuncu Güncellendi.", player.FullName);
        }
    }
}
