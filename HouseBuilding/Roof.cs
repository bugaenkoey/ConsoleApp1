using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Roof : Part
    {

     //   public  OrderBuilder Order { get => OrderBuilder.Roof; }
        public override OrderBuilder OrderBuilder => OrderBuilder.Roof; 
    }
}
