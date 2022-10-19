using GameManagementSystemApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementSystemApp.Entity
{
    public class Game 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }
    }
}
