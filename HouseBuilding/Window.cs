using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Window : Part
    {
        //public OrderBuilder Order { get => OrderBuilder.Window; }
        public override OrderBuilder OrderBuilder  => OrderBuilder.Window; 
    }
}
