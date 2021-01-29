using System;

namespace MySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = string.Empty;

            var car = new Car
            {
                Speed = 5
            };
            var person = new Person()
            {
                FirstName = "FN",
                LastName = "LN"
            };

            try
            {
                var mySerialized = Serializer.Serialize(car);
                Console.WriteLine(mySerialized);
                //var jsonSerialized = JsonConvert.SerializeObject(person, Formatting.Indented);
                //Console.WriteLine(jsonSerialized);

                var deserializedMine = Serializer.Deserialize<Car>(mySerialized);
                //var deserializedJson = JsonConvert.DeserializeObject<Person>(jsonSerialized);
            }
            catch (StatusCodeException e)
            {
                Console.WriteLine(e.StatusCode);
                Console.WriteLine(e.Message);
                Environment.Exit((int)e.StatusCode);
            }
        }
    }

    class Car
    {
        public int Speed { get; set; }

        public int MaxSpeed => Speed * 10;
    }

    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string LastName1 { get; set; }

        //public List<Person> Childern { get; set; }
    }

    
    class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
    }

}