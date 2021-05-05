using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Manager
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Product product, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " discount has been added to the game called" + product.ProductName );
        }

        public void Delete(Product product, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" discount has been removed from the game called " + product.ProductName);
        }

        public void Update(Product product, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " discount for the game called " + product.ProductName + " has been updated");
        }
    }
}
