using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    public class Basement : IPart
    {
        public Basement()
        {
            PercentCompleted = 0;
            Completed = false;
        }

        public Basement(decimal percentCompleted, bool completed)
        {
            PercentCompleted = percentCompleted;
            Completed = completed;
        }

        public decimal PercentCompleted { get ; set ; }
        public bool Completed { get ; set ; }

        public string Building()
        {
            return "Строим Basement";

        }
    }
}
