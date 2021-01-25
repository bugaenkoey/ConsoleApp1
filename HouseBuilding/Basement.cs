using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Basement : Part
    {
        //  public OrderBuilder Order = OrderBuilder.Basement;
        public override OrderBuilder OrderBuilder => OrderBuilder.Basement;

    }

}
