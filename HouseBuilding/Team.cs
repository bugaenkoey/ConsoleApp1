using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{

    class Team
    {
        public List<Builder> builders = new List<Builder>();
        public List<TeamLeader> teamLeaders = new List<TeamLeader>();

        public Team(Builder builders, TeamLeader teamLeaders)
        {
            this.builders.Add(builders);
            this.teamLeaders.Add(teamLeaders);
        }

        public Team(Builder[] builders1, TeamLeader[] teamLeaders1)
        {
            Builders = builders1;
            TeamLeaders = teamLeaders1;
        }

        public Builder[] Builders { get; }
        public TeamLeader[] TeamLeaders { get; }
    }
}
