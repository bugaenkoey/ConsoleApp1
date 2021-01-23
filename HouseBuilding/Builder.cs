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

     /*   public int EnergyDown()
        {
            int power = new Random().Next(10, 20);
            Energy -= power;
            return power;
        }
*/
        public void EnergyUp()
        {
            if(Energy<100) Energy += new Random().Next(5, 15);
        }

        public string Work(ref ProjectHouse projectHouse)
        {
            string str = string.Empty;
            /*  if (Energy >= 80 )
              {
                  str = $"Work {Name} {GetType()} ";
                 int power = EnergyDown();
                  foreach (var item in projectHouse.listPart)
                  {
                      Console.WriteLine($"{this.Name}{item.Building()}");
                      item.PercentCompleted += power;

                  }

              }*/
            if (Energy >= 80)
            {
                str = $"Work {Name} ";
              //  int power = EnergyDown();
                foreach (var item in projectHouse.listPart)
                {
                    if (Energy >= 80)
                    {
                        Energy -= item.Building();
                    }
                    else { break; }
                  //  Console.WriteLine($"{this.Name}{item.Building()}");
                  //  item.PercentCompleted += power;

                }

            }
            else
            {
                str = $"{Name} {GetType()} Not Work";
                EnergyUp();
            }
            Console.Write($"Energy{Energy}");
            return str; 
        }
    }
}
