using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{

    class ProjectHouse
    {
        public List<IPart> listPart = new List<IPart>();

        public ProjectHouse()
        {
            Completed = false;
        }

        public bool Completed { get; set; }
        internal void AddPart(IPart part)
        {
            listPart.Add(part);
            Console.WriteLine($"Add {part.GetType()}");
        }


    }
}
