using GameMarketSimulation.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    class SaleManager
    {

        public void Sell(Product product, Campaign campaign, User user)
        {
            DiscountManager discountManager = new DiscountManager(new DiscountCheck());
            Console.WriteLine(user.FirstName + " purchased " + product.Name + " for " + discountManager.CalculateDiscount(product, campaign) + "$");
        }
    }
}
