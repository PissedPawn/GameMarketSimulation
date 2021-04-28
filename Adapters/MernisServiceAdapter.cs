using GameMarketSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Adapters
{
    class MernisServiceAdapter : IEntityCheckManager
    {
        public bool CheckIfRealPerson(Entity entity)
        {
            return false;
        }
    }
}
