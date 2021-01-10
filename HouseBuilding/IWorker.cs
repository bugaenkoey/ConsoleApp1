using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    interface IWorker
    {

        string Name { get; set; }
     //   byte Energy { get; set; }
        string Work();
     //   string PauseWork();
    }
}
