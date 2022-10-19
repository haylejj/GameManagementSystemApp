using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Entity;

namespace GameManagementSystemApp.Abstract
{
    public interface IPlayer
    {
        void SignUp(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
