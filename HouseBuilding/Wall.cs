using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Wall : Part
    {
   //     public OrderBuilder Order { get => OrderBuilder.Wall; }
        public override OrderBuilder OrderBuilder  => OrderBuilder.Wall; 

    }
}
