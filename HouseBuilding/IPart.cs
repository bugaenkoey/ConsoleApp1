using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    public interface IPart
    {
     
        decimal PercentCompleted { get; set; }
       
        bool Completed { get; set; }
        int Building();
        
    }
}
