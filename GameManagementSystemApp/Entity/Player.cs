using GameManagementSystemApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementSystemApp.Entity
{
    public class Player
    {
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string TcId { get; set; }
        public DateTime DateOfBirthYear { get; set; }
    }
}
