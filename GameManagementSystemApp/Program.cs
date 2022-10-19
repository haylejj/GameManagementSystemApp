using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Abstract;
using GameManagementSystemApp.Concrete;
using GameManagementSystemApp.Entity;
using GameManagementSystemApp.MersisServiceReference1;

namespace GameManagementSystemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1=new Player();
            player1.FullName="Çağatay Berk";
            player1.LastName="Cingiz";
            player1.TcId="39055554152";
            player1.DateOfBirthYear=new DateTime(2001, 11, 5);

            PlayerManagement playerManagement = new PlayerManagement(new PlayerCheckManagement());
            playerManagement.SignUp(player1 );
        }
    }
}
