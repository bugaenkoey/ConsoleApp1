using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class TeamLeader : IWorker
    {
        private static int id;
        public TeamLeader() : this("TeamLeader")
        {
        }

        public TeamLeader(string name)
        {
            id++;
            Name = name + id;
        }

        public string Name { get; set; }



        public string Work(ref ProjectHouse projectHouse)
        {
            Console.WriteLine($" Work {Name} ");
            bool check = true;

            foreach (var item in projectHouse.listPart)
            {
                Console.WriteLine($" {item.GetType()} PercentCompleted {item.PercentCompleted} ");
                if (item.Completed)
                {
                    Console.WriteLine($"{item.GetType()}++++++++++++++++++++++GOTOVO");

                }
                else
                {
                    check = false;
                }

         /*       else
                {
                  //  projectHouse.Completed = true;
               //     Console.WriteLine("House #################################");
               //     Completed(ref projectHouse);
                   // new House(ref projectHouse);
                    break;
                }*/
            }
            if (check)
            {
                projectHouse.Completed = true;
                new House(projectHouse);
            }

          //  return $" Work {Name} ";
            return $" .... ";

        }

        public House Completed(ref ProjectHouse projectHouse)
        {
            return new House( projectHouse);
        }
    }

}
