using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;

namespace Repository2CRUD
{
    /*Задание 2: 
Реализовать интерфейс классом Repository<T>, который будет производить
    непосредственные манипуляции с данными.
В текущей реализации репозиторий будет инкапсулировать работу с таблицей данных. 
    Например класс Repository<Book> будет реализовывать доступ к таблице Books.
    */
    public class Repository<T> : IRepository<T> where T : new()
    {
        //protected readonly SqlConnection Connect;
        protected readonly string TableName = $"{typeof(T).Name}s";
        public string Id_DB { get; set; }
        public string StringConect { get; set; }
        // @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
        private DbConnection Connect = null;
        public SqlDataReader sqlDataReader = null;
        public SqlCommand sqlCommand = new SqlCommand();




        public Repository(string id_DB)
        {
            Id_DB = id_DB;
            CreateDbIfNot();
            CreateTableIfNot();
            {
                /*
    If(db_id(N'TestCreateDB11') IS NULL)
    begin
    --DROP DATABASE [TestCreateDB11]
    CREATE DATABASE [TestCreateDB11]
    end
    go
    use [TestCreateDB11]
                 * */
                // LAPTOP-046QU23H\SQLEXPRESS
                // If(db_id(N'DBNAME') IS NULL)

            }
            //  StringConect = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
            StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog={Id_DB};Integrated Security=True;";
            Connect = new SqlConnection(StringConect);
            OpenConectDB();

            Connect.Close();
        }

        /*
CREATE TABLE [dbo].[Table]
(
[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
[Name] NVARCHAR(50) NOT NULL, 
[Count] INT NOT NULL
)
*/
        private void CreateTableIfNot()
        {
            StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog= {Id_DB};Integrated Security=True;";
          //  string StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog={Id_DB}Integrated Security=True;";

            SqlConnection Connect = new SqlConnection(StringConect);

            Connect.Open();  ///////////???????????????????

            //подготовить запрос insert
            //в переменной типа string
          

            string insertString = $" USE {Id_DB} " +
           $"if not exists(select * from sysobjects where name = '{TableName}')" +
           $" CREATE TABLE[dbo].[{TableName}]" +
           $" ( Id INT NOT NULL PRIMARY KEY IDENTITY," +
           $"Name NVARCHAR(50) NOT NULL," +
           $"Count INT NOT NULL )";


            //создать объект command,
            //инициализировав оба свойства
            SqlCommand cmd = new SqlCommand(insertString, Connect);
            //выполнить запрос, занесенный
            //в объект command

            
            cmd.ExecuteNonQuery();///??????????????????????     
            Connect.Close();
        }


        public void CreateDbIfNot()
        {
            string StringConect = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;";

            SqlConnection Connect = new SqlConnection(StringConect);
            Connect.Open();
            //подготовить запрос insert
            //в переменной типа string
            //CREATE DATABASE IF NOT EXISTS MySampleDB;
            string insertString = $"If(db_id(N'{Id_DB}') IS NULL) CREATE DATABASE[{Id_DB}]";


            //создать объект command,
            //инициализировав оба свойства
            SqlCommand cmd = new SqlCommand(insertString, Connect);
            //выполнить запрос, занесенный
            //в объект command

            cmd.ExecuteNonQuery();
            Connect.Close();
        }
        private void OpenConectDB()
        {
            try
            {
                Connect.Open();
                Console.WriteLine($"Connect OK \nStringConect = {StringConect}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error SqlConnection StringConect = {StringConect}");
            }
        }

        public void AddElement(T element)
        {
            throw new NotImplementedException();
        }

        public void ChangeElement(T element)
        {
            throw new NotImplementedException();
        }

        public void DeleteElement(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllData()
        {
            OpenConectDB();
            List<T> listElement = new List<T>();
            // List<string[]> listElement = new List<string[]>();

            string select = $"select * from {TableName}";
            sqlCommand = new SqlCommand(select, (SqlConnection)Connect);

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                var schema = sqlDataReader.GetColumnSchema();
                while (sqlDataReader.Read())
                {
                    listElement.Add(Create(schema, sqlDataReader));
                }
                Console.WriteLine("Элементы получены");

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine($"Недопустимое имя объекта {TableName} ");
            }
            finally
            {
                Connect.Close();
            }
            return listElement;

        }

        private T Create(ReadOnlyCollection<DbColumn> schema, SqlDataReader sqlDataReader)
        {
            T element = new T();


            return element;
        }

        public T GetElementById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
