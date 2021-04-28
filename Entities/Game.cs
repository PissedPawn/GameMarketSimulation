using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    class Game:Product
    {
        public Game():base()
        {

        }

        public Game(int id, string name, DateTime dateAdded, double price, string detail) :base(id, name, dateAdded, price, detail)
        {

        }
    }
}
