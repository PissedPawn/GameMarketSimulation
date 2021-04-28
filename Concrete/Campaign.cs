using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Concrete
{
    class Campaign
    {
        public List<Product> products { get; set; }
        public int DiscountRate { get; set; }
    }
}
