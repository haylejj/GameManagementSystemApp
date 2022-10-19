using GameManagementSystemApp.Abstract;
using GameManagementSystemApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementSystemApp.Concrete
{
    public class GameManagement : IGame
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} Oyunu Başarıyla Eklendi",game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} Oyunu Silindi!!!", game.Name);
        }
    }
}
