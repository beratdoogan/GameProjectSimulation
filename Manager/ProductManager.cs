using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Abstract
{
    public class ProductManager : Product,IProductService
    {
        public void Buy(Gamer gamer, Product product)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has purchased " + product.ProductName);
        }

        public void Return(Gamer gamer, Product product)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " has returned to " + product.ProductName );
        }
        public int CampaignPercentCalculate(Product product,Campaign campaign)
        {
            return (product.ProductPrice * campaign.CampaignAmount/100);
        }

        public void CampaignSales(Product product, Campaign campaign)
        {
            int result = CampaignPercentCalculate(product,campaign);
            Console.WriteLine("Campaign applied price : " + result);
        }
    }
}
