using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBuilding
{
    class Builder : IWorker, IEnergy
    {
        private static int id;
   
        public Builder():this("Builder")
        {                     
        }

        public Builder(string name)
        {
            
            id++;
            Name = name+id;
            Energy = new Random().Next(80, 100);
            Console.WriteLine($"Energy{Energy}");
        }

        public string Name { get ; set ; }
        public int Energy { get ; set ; }

        public void EnergyDown()
        {
            Energy -= new Random().Next(10, 20);
        }

        public void EnergyUp()
        {
            Energy += new Random().Next(5, 15);
        }

        public string Work()
        {
            string str = string.Empty;
            if (Energy >= 80 )
            {
                str = $"Work {Name} {GetType()}";
                EnergyDown();
            }
            else
            {
                str = $"{Name} {GetType()} Not Work";
                EnergyUp();
            }

            return str; 
        }
    }
}
