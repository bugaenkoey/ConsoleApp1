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


        /*
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
        */

        public string Work(ref ProjectHouse projectHouse)
        {
            string str = string.Empty;
            OrderBuilder orderBuilder;
            bool previewOrderComplead;
            if (Energy >= 80)
            {


                foreach (var item in projectHouse.listPart)
                {

                    //+++++++++++++++++++++++++
                    
                    orderBuilder = item.OrderBuilder;
                    previewOrderComplead = true;

                    foreach (var itemCheck in projectHouse.listPart)
                    {
                        if (itemCheck.OrderBuilder == (orderBuilder - 1) && itemCheck.Completed == false)
                        {
                            previewOrderComplead = false;
                        }
                    }

                    if (!previewOrderComplead)
                    {

                        Console.WriteLine($"{Name} Невозможно построить {item.OrderBuilder} Пред идущий объект {item.OrderBuilder - 1} не построен ");
                        continue;
                    }

                    //--------------------------
                    if (Energy >= 80)
                    {
                        int power = item.Building();
                        str = $"{Name} Энергии {Energy}. На строительство объекта {item.OrderBuilder} потрачено {power}% энергии.";
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
                str = $"{Name} Мало энергии - {Energy}. Не работает, отдыхает.";
                EnergyUp();
            }
            return str;
        }
        public bool CheckPreview()
        {

            return false;
        }

    }
}
