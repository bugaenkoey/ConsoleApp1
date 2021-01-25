using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class TeamLeader : IWorker
    {
        private static int id;
        public TeamLeader() : this("Бригадир")
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
            Console.WriteLine($"Работает {Name} ");
            bool check = true;

            foreach (var item in projectHouse.listPart)
            {
                if (item.Completed)
                {
                    Console.WriteLine($"{item.OrderBuilder}\tСтроительство завершено ГОТОВО!!!");

                }
                else
                {
                Console.WriteLine($"{item.OrderBuilder}\tОбъект готов на {item.PercentCompleted}%");
                    check = false;
                }

            }
            if (check)
            {
                projectHouse.Completed = true;
                //  new House(projectHouse);
            }

            return $" .... ";

        }

        public House Completed(ref ProjectHouse projectHouse)
        {
            return new House(projectHouse);
        }
    }

}
