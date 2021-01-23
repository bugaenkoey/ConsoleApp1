using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    interface IWorker
    {
     //   int Energy { get; set; }
        string Name { get; set; }
     //   byte Energy { get; set; }
        string Work();
     //   string PauseWork();
    }
}
