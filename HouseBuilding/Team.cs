using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{

    class Team
    {
       // public List<Builder> builders = new List<Builder>();
       // public List<TeamLeader> teamLeaders = new List<TeamLeader>();
        public List<IWorker> workers;

        /*   public Team(List<Builder> builders, List<TeamLeader> teamLeaders)
           {

               this.builders = builders;
               this.teamLeaders = teamLeaders;
           }*/
        public Team(List<Builder> builders, List<TeamLeader> teamLeaders)
        {
            workers = new List<IWorker>();
            workers.AddRange(builders);
            workers.AddRange(teamLeaders);
            /* foreach (var item in workers)
             {
                 Console.WriteLine(item.Name);
             }*/

        }
    }
}
