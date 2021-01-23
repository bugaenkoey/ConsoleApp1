using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class TeamLeader:IWorker
    {
        private static int id;
        public TeamLeader(): this("TeamLeader")
        {
        }

        public TeamLeader(string name)
        {
            id++;
            Name = name+id;
        }

        public string Name { get; set; }

       

        public string Work()
        {
            
            return $"Work {Name} {GetType()}";
        }
    }
    
}
