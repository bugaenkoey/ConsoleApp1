﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{

    class Team
    {

        public List<IWorker> workers;

        public Team(List<Builder> builders, List<TeamLeader> teamLeaders)
        {
            workers = new List<IWorker>();
            workers.AddRange(builders);
            workers.AddRange(teamLeaders);

        }
        public ref ProjectHouse Work(ref ProjectHouse projectHouse)
        {
            while (!projectHouse.Completed)
            {


                foreach (var item in workers)
                {
                    Console.WriteLine(item.Work(ref projectHouse));
                }
            }
            return ref projectHouse;
        }



    }
}
