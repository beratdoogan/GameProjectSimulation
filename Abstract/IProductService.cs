using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;


namespace GameProject.Abstract
{
    public interface IProductService
    {
        void Buy(Gamer gamer,Product product);
        void Return(Gamer gamer, Product product);
        void CampaignSales(Product produt, Campaign campaign);
        
    }
}
