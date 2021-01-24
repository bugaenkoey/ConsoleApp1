using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    interface IWorker
    {
        string Name { get; set; }
        string Work(ref ProjectHouse projectHouse);
    }
}
