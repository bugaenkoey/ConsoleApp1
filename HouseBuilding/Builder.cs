using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Builder : IWorker, IEnergy
    {
        private static int id;

        public Builder() : this("Builder")
        {
        }

        public Builder(string name)
        {

            id++;
            Name = name + id;
            Energy = new Random().Next(80, 100);
            Console.WriteLine($"Energy{Energy}");
        }

        public string Name { get; set; }
        public int Energy { get; set; }


        public void EnergyUp()
        {
            if (Energy < 100) Energy += new Random().Next(5, 15);
        }

        public string Work(ref ProjectHouse projectHouse)
        {
            string str = string.Empty;

            if (Energy >= 80)
            {


                foreach (var item in projectHouse.listPart)
                {
                    if (Energy >= 80)
                    {
                        int power = item.Building();
                        str = $" {Name} Energy {Energy} {item.GetType()} + {power} Work +++";
                        Energy -= power;
                    }
                    else
                    {

                        break;
                    }
                }
            }
            else
            {
                str = $"{Name} Energy Low {Energy}  --- Not Work";
                EnergyUp();
            }
            return str;
        }
    }
}
