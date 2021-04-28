using GameMarketSimulation.Concrete;
using GameMarketSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstract
{
    interface IDiscountCheckService
    {
        bool IfHasDiscount(Product product, Campaign campaign);
    }
}
