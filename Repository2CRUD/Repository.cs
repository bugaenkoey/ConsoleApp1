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
        
        protected readonly string TableName = $"{typeof(T).Name}s";

        public string Id_DB { get; set; } = $"DB_{typeof(T).Name}";
        public string StringConect { get; set; }
        // @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
        private readonly DbConnection Connect = null;
        public SqlDataReader sqlDataReader = null;


        public Repository(string id_DB): this ()
        {
            Id_DB = id_DB;
          /*  CreateDbIfNot();
            CreateTableIfNot();

            StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog={Id_DB};Integrated Security=True;";
            Connect = new SqlConnection(StringConect);

            OpenConectDB();
            Connect.Close();*/
        }

        public Repository()
        {
          //  Id_DB = $"DB_{typeof(T).Name}";
            CreateDbIfNot();
            CreateTableIfNot();

            StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog={Id_DB};Integrated Security=True;";
            Connect = new SqlConnection(StringConect);

            OpenConectDB();
            Connect.Close();
        }


        private void CreateTableIfNot()
        {
            StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog= {Id_DB};Integrated Security=True;";

            SqlConnection Connect = new SqlConnection(StringConect);

            Connect.Open();

            { /*
                        string insertString = $" USE {Id_DB} " +
                       $"if not exists(select * from sysobjects where name = '{TableName}')" +
                       $" CREATE TABLE[dbo].[{TableName}]" +
                       $" ( " +
                       $"Id INT NOT NULL PRIMARY KEY IDENTITY," +
                       $"Name NVARCHAR(50) NOT NULL," +
                       $"Count INT NOT NULL )";
                 */
            }

            string insertString = GererateScriptCreateTable();

            SqlCommand cmd = new SqlCommand(insertString, Connect);

            cmd.ExecuteNonQuery();///??????????????????????     
            Connect.Close();
        }
        private string GererateScriptCreateTable()
        {
            string scriptTable = $" USE {Id_DB} " +
         $"if not exists(select * from sysobjects where name = '{TableName}')" +
         $" CREATE TABLE[dbo].[{TableName}]" +
         $" ( ";
            var propertiT = typeof(T).GetProperties();
            for (int i = 0; i < propertiT.Length; i++)
            {
                var typeT = TypeConvertToSQL.Convert(propertiT[i].PropertyType.ToString());

                scriptTable += $"{propertiT[i].Name} {typeT} NOT NULL";
                scriptTable += propertiT[i].Name == "Id" ? $" PRIMARY KEY IDENTITY" : "";
                scriptTable += i + 1 < propertiT.Length ? " ," : " )";
            }

            return scriptTable;
        }

        public void CreateDbIfNot()
        {
            string StringConect = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;";

            SqlConnection Connect = new SqlConnection(StringConect);
            Connect.Open();
            //подготовить запрос insert
            //в переменной типа string
            //CREATE DATABASE IF NOT EXISTS {Id_DB};
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

        public void Add(T element)
        {
            string StringConect = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;";

            SqlConnection Connect = new SqlConnection(StringConect);
            Connect.Open();

            //INSERT INTO tableName
            // VALUES(value1, value2, ...);
            /*  MyElement myElement = new MyElement();
              myElement.Id = 8;
              myElement.Name = "testElement";
              myElement.Count = 88;
  */
            string insertString = $" USE {Id_DB} INSERT INTO {TableName} VALUES(";

            var propertiT = element.GetType().GetProperties();

            for (int i = 1; i < propertiT.Length; i++)
            {
                insertString += $"'{ propertiT[i].GetValue(element)}'";
                insertString += i + 1 < propertiT.Length ? " ," : " );";
            }
            SqlCommand cmd = new SqlCommand(insertString, Connect);
            cmd.ExecuteNonQuery();
            Connect.Close();
        }

        public void ChangeElement(T element)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int idDelite)
        {
            string StringConect = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;";

            SqlConnection Connect = new SqlConnection(StringConect);
            Connect.Open();
            string insertString = $" USE {Id_DB} DELETE FROM {TableName } WHERE id = {idDelite };";
            SqlCommand cmd = new SqlCommand(insertString, Connect);
            cmd.ExecuteNonQuery();
            Connect.Close();
        }

        public List<T> GetAll()
        {
            List<T> listElement = new List<T>();
           
            string select = $"select * from {TableName}";
            SqlCommand sqlCommand = new SqlCommand(select, (SqlConnection)Connect);

            try
            {
            OpenConectDB();
                sqlDataReader = sqlCommand.ExecuteReader();

                var schema = sqlDataReader.GetColumnSchema();

                while (sqlDataReader.Read())
                {
                    var elementT = Create(schema, sqlDataReader);
                    listElement.Add(elementT);
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
            var propertiT = element.GetType().GetProperties();

            for (int i = 0; i < schema.Count; i++)
            {
                var value = sqlDataReader[i];
                propertiT[i].SetValue(element, value);
            }
            return element;
        }

        public T GetElementById(int id)
        {
            T element = new T();

            string select = $"select * from {TableName} where id= {id}";
            SqlCommand sqlCommand = new SqlCommand(select, (SqlConnection)Connect);

            try
            {
            OpenConectDB();
                sqlDataReader = sqlCommand.ExecuteReader();

                var schema = sqlDataReader.GetColumnSchema();

                while (sqlDataReader.Read())
                {
                    element= Create(schema, sqlDataReader);
                }
                Console.WriteLine("Элемент получен");

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
            return element;
        }
    }
}
