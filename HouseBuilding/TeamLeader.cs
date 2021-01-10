using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class TeamLeader
    {
        ProjectCountPart Project { get; set; }
         public  TeamLeader(ProjectCountPart project)
        {
            Project = project;
        }
        public TeamLeader()
        { }
    }
    
}
