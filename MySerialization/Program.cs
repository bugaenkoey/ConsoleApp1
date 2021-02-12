using System;

namespace MySerialization
{
    /*«Платформа Microsoft .NET и язык программирования C#»
№5 Тема: Введение в работу с рефлексией и сериализацией
Материалы:
При выполнении этого задания вам могут понадобиться учебные материалы
    по теме сериализация, а также дополнительная информация по теме.
https://gist.github.com/reslea/8b4887f74494ce33314bae1f2c46c878
Цель: 
•	изучение библиотек .NET; 
•	приобретение практических навыков работы с основными интерфейсами платформы. 
Задание: 
Доработать (де)сериализатор объектов, разработанный на паре (ссылка на github):
https://github.com/reslea/BasicTasks/tree/master/Serialization
•	Добавить поддержку (де)сериализации вложенных типов, например, 
    добавив классу Person, свойство класса Address. Класс Address в свою очередь
    имеет 3 свойства: City, Street, Building
•	Добавить поддержку (де)сериализации значений null
•	Добавить поддержку (де)сериализации типов decimal, double, char и float

     */
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
                FirstName = "Bugaenko",
                LastName = "Evgen",
                City="Kherson",
                Street="Perekopsrsya",
                Building="20"
            };
            var fn = person.FirstName;
            Console.WriteLine(fn);
            //SerializationPerson serializationPerson = new SerializationPerson();
            var sPerson = SerializationPerson.Serialization(person);
            var myObj = SerializationPerson.Deserialize<Person>(sPerson);
            Console.WriteLine(myObj);

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

            //+++++++++++++++++++++++++
            try
            {
                var mySerialized1 = Serializer.Serialize(person);
                Console.WriteLine(mySerialized1);
                //var jsonSerialized = JsonConvert.SerializeObject(person, Formatting.Indented);
                //Console.WriteLine(jsonSerialized);

                var deserializedMine1 = Serializer.Deserialize<Car>(mySerialized1);
                //var deserializedJson = JsonConvert.DeserializeObject<Person>(jsonSerialized);
            }
            catch (StatusCodeException e)
            {
                Console.WriteLine(e.StatusCode);
                Console.WriteLine(e.Message);
                Environment.Exit((int)e.StatusCode);
            }
            //-----------------


        }
    }

    class Car
    {
        public int Speed { get; set; }

        public int MaxSpeed => Speed * 10;
    }

    class Person : Address
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public void MyMethod()
        {
            Console.WriteLine($"{FirstName}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        private string LastName1 { get; set; }
        //public string address { get; set { } }
      //  public Address address = new Address();
  /*      {
            City = "MyCity",
            Street = "MyStreet",
            Building = "MyBuilding"
        };
*/
        //public List<Person> Childern { get; set; }
    }

    
    class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
    }

}