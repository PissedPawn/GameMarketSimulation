using GameMarketSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    class User:Entity
    {
        public User()
        {

        }
        public User(int id, string name, string lastName, DateTime date, string idNo) :base(id, name, lastName, date, idNo)
        {

        }

    }
}
