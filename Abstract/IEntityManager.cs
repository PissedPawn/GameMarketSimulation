using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstract
{
    interface IEntityManager
    {
        void Register(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
