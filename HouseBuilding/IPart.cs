using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    public interface IPart
    {

        int PercentCompleted { get; set; }

        bool Completed { get; set; }
        int Building();

    }
}
