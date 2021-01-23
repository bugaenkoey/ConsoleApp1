using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    
    class ProjectHouse
    {
        public List<IPart> listPart = new List<IPart>();

        internal void AddPart(IPart part)
        {
            listPart.Add(part);
            Console.WriteLine($"Add {part.GetType()}");
        }
    }
}
