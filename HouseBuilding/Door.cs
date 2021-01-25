using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Door : Part
    {
     //   public OrderBuilder Order { get => OrderBuilder.Door; }
        public override OrderBuilder OrderBuilder  => OrderBuilder.Door; 
    }
}
