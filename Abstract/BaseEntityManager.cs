using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstract
{
    abstract class BaseEntityManager : IEntityManager
    {
        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.FirstName + " deleted from system.");
        }

        public virtual void Register(Entity entity)
        {
            Console.WriteLine(entity.FirstName + " registered successfully.");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.FirstName + " updated information successfully.");
        }
    }
}
