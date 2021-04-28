using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Abstract
{
    class Entity
    {
        public Entity()
        {

        }

        public Entity(int id, string name, string lastName, DateTime date, string idNo)
        {
            Id = id; FirstName = name; LastName = lastName; BirthDate = date; IdentificationNumber = idNo;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public string IdentificationNumber { get; set; }

    }
}
