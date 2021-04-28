using GameMarketSimulation.Abstract;
using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Concrete
{
    class DiscountCheck : IDiscountCheckService
    {
        public bool IfHasDiscount(Product product, Campaign campaign)
        {
            if (campaign.products.Contains(product))
                return true;
            else return false;
        }
    }
}
