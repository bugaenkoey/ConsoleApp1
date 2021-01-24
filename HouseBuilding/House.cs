using System;
using System.Collections.Generic;

namespace HouseBuilding
{
    internal class House
    {

        public ProjectHouse projectHouse;

        public House(ProjectHouse projectHouse)
        {
            this.projectHouse = projectHouse;
            Console.WriteLine("****************************Cтроительство дома завершено! ******************************");

        }

    }
}