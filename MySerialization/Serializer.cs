using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySerialization
{
    public static class Serializer
    {
        public static string Serialize<T>(T @object)
        {
            var type = typeof(T);

            var properties = type.GetProperties();

            var serialized = $"{type.Name}*";

            foreach (var propertyInfo in properties)
            {
                var getMethod = propertyInfo.GetGetMethod();

                if (getMethod == null) continue;

                serialized += $"{propertyInfo.Name}:";
                var value = getMethod.Invoke(@object, null);

                serialized += value;
                serialized += "|";
            }

            // to remove last | from serialized
            return serialized.Substring(0, serialized.Length - 1);
        }

        public static T Deserialize<T>(string serialized) where T : new()
        {
            if (serialized == null) throw new ArgumentNullException(nameof(serialized));

            var type = typeof(T);

            var indexOfAsterics = serialized.IndexOf('*');
            var typeName = serialized.Substring(0, indexOfAsterics);
            if (type.Name != typeName) throw new ArgumentException();

            var propertiesInfo = serialized.Substring(indexOfAsterics + 1, serialized.Length - (indexOfAsterics + 1));

            var propertiesValues = propertiesInfo.Split("|");

            var deserialized = new T();
            var properties = type.GetProperties();
            foreach (var propertyValueInfo in propertiesValues)
            {
                var splitted = propertyValueInfo.Split(":");
                var propertyName = splitted[0];
                var propertyValue = splitted[1];

                var setMethod = properties
                    .First(p => p.Name == propertyName)
                    .GetSetMethod();

                if (setMethod == null) continue;

                var parameterType = setMethod.GetParameters()[0].ParameterType;
                if (parameterType == typeof(int))
                {
                    setMethod.Invoke(deserialized, new object[] { Convert.ToInt32(propertyValue) });
                }
                else if (parameterType == typeof(decimal))
                {
                    setMethod.Invoke(deserialized, new object[] { Convert.ToDecimal(propertyValue) });
                }
                if (parameterType == typeof(string))
                {
                    setMethod.Invoke(deserialized, new[] { propertyValue });
                }
                else
                {
                    throw new StatusCodeException(StatusCode.InvalidFunction, $"cannot parse {propertyName}");
                }
            }

            return deserialized;
        }
    }
}