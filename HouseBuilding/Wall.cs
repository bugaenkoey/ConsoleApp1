using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Wall : IPart
    {
        public decimal PercentCompleted { get ; set ; }
        public bool Completed { get ; set ; }

        public string Building()
        {
            return "Строим Wall";
        }
    }
}
