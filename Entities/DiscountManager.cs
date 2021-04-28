using GameMarketSimulation.Abstract;
using GameMarketSimulation.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    class DiscountManager: CampaignManager
    {
        IDiscountCheckService _discountCheckService;

        public DiscountManager(IDiscountCheckService discountCheckService)
        {
            _discountCheckService = discountCheckService;
        }

        public List<Product> discountedProducts = new List<Product>();
        public override void AddCampaign(Campaign campaign)
        {
            foreach (var item in campaign.products)
            {
                Console.WriteLine(campaign.DiscountRate + " discount has been applied to " + item.Name);
                discountedProducts = campaign.products;
            }
        }
        public double CalculateDiscount(Product product, Campaign campaign)
        {
            if (_discountCheckService.IfHasDiscount(product, campaign))
                return product.Price -= product.Price * campaign.DiscountRate / 100;
            else
                return product.Price;
            
        }
    }
}
