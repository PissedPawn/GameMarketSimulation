using GameMarketSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Concrete
{
    class CustomerManager :BaseEntityManager
    {
        IEntityCheckManager _entityCheckManager;

        public CustomerManager(IEntityCheckManager entityCheckManager)
        {
            _entityCheckManager = entityCheckManager;
        }
      

        public override void Register(Entity entity)
        {
            if (_entityCheckManager.CheckIfRealPerson(entity))
                base.Register(entity);
            else
                Console.WriteLine("Not a real person");
        }

       
    }
}
