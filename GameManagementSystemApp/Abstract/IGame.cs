using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Entity;

namespace GameManagementSystemApp.Abstract
{
    public interface IGame
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
