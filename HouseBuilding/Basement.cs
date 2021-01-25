using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Basement : Part
    {
        public override OrderBuilder OrderBuilder => OrderBuilder.Basement;
    }

}
