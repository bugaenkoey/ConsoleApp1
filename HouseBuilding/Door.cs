using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Door : Part
    {
        public override OrderBuilder OrderBuilder => OrderBuilder.Door;
    }
}
