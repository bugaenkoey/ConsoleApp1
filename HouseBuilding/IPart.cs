using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    public interface IPart
    {
        int quantity { get; set; }
        decimal Percent { get; set; }
        bool Completed { get; set; }
        string Building();
    }
}
