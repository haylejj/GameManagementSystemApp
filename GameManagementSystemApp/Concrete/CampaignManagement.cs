using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManagementSystemApp.Abstract;
using GameManagementSystemApp.Entity;

namespace GameManagementSystemApp.Concrete
{
    public class CampaignManagement : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi!! {0} kampanyasının indirim oranı : {1} ",campaign.Name,campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} Kampanyası silindi!!. Artık mevcut değil.",campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi!! {0} kampanyasının indirim oranı : {1} olarak değiştirildi ", campaign.Name, campaign.DiscountRate);
        }
    }
}
