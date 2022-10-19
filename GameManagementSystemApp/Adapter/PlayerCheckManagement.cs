using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Abstract;
using GameManagementSystemApp.Entity;
using GameManagementSystemApp.MersisServiceReference1;

namespace GameManagementSystemApp.Concrete
{
    public class PlayerCheckManagement : IPlayerCheckService
    {
        public bool CheckPlayer(Player player)
        {
           KPSPublicSoapClient client=new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.TcId), player.FullName, player.LastName, player.DateOfBirthYear.Year);

        }
    }
}
