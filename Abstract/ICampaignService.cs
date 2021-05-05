using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Product product, Campaign campaign);
        void Update(Product product, Campaign campaign);
        void Delete(Product product, Campaign campaign);

    }
}
