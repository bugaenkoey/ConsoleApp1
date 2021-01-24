using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{

    interface IEnergy
    {
        int Energy { get; set; }
        void EnergyUp();
    }
}
