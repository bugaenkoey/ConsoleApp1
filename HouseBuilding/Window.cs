﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Window : Part
    {
        public override OrderBuilder OrderBuilder  => OrderBuilder.Window; 
    }
}
