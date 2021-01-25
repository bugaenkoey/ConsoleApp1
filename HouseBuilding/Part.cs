using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Part : IPart
    {
        public Part()
        {
            PercentCompleted = 0;
            Completed = false;
        }
        public virtual OrderBuilder OrderBuilder { get ; set ; }

        public int PercentCompleted { get; set; }
        public bool Completed { get; set; }

        public int Building()
        {
            int power = 0;

            if (!Completed)
            {
                power = new Random().Next(10, 20);

                if (PercentCompleted + power >= 100)
                {
                    power = 100 - PercentCompleted;
                    Completed = true;
                }

                PercentCompleted += power;

            }
            // if (PercentCompleted >= 100) Completed = true;

            return power;
        }

        public bool CheckPreview()
        {

            return false;
        }

     
    }
}
