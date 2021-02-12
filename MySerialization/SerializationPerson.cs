using System;
using System.Collections.Generic;
using System.Text;

namespace MySerialization
{
    public static class SerializationPerson
    {
        public static string Serialization<T>(T obj)
        {
            string str = string.Empty;

            var type = typeof(T);


            var name = type.Name;
            str += $"";
            var getProperties = type.GetProperties();

            for (int i = 0; i < getProperties.Length; i++)
            {
                str += $"{getProperties[i].Name}:{getProperties[i].GetGetMethod().Invoke(obj, null)}";
                if (i < getProperties.Length - 1) str += ",";
            }
            //Base Class
/*            str += "[";
            var getBaseProperties = type.BaseType.GetProperties();
            for (int i = 0; i < getBaseProperties.Length; i++)
            {
                str += $"{getBaseProperties[i].Name}:{getBaseProperties[i].GetGetMethod().Invoke(obj, null)}";
                if (i < getBaseProperties.Length - 1) str += ",";

            }
            str += "]";

*/
            /*
                        foreach (var item in properties)
                        {

                            var getMethod = item.GetGetMethod();
                            if (getMethod == null) continue;
                            str += $"{item.Name}:{getMethod.Invoke(obj,null)},";


                        }
            */
            Console.WriteLine(str);

            return str;
        }

        public static T Deserialize<T>(string str) where T : new()
        {
            var type = typeof(T);
            T obj = new T();

            foreach (var item in obj)
            {

            }
            var param = str.Split(",");
            var getPropertiesT = type.GetProperties();
            // getPropertiesT.SetValue
            for (int i = 0; i < getPropertiesT.Length; i++)
            {
                var strT = param[i].Split(":")[1];
                // getPropertiesT[i] = strT;
                Console.WriteLine($"{getPropertiesT[i]}={param[i].Split(":")[1]}");
                // str += $"{getProperties[i].Name}:{getProperties[i].GetGetMethod().Invoke(obj, null)}";
                //  if (i < getProperties.Length - 1) str += ",";
            }

            return obj;
        }


    }
}
