using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStorage
{
    public partial class Form1 : Form
    {
        public SqlDataReader sqlDataReader = null;
        public SqlCommand sqlCommand = new SqlCommand();
        public string StringConect { get; set; }
        public SqlConnection Connect = null;
        public string Id_DB { get; set; } = string.Empty;
        private DatabaseQueries[] databaseQueries = null;
        public SqlParameter paramCarent = new SqlParameter();
        public string TableProducts { get; set; } = "Products";
        public string TableTypes { get; set; } = "Types";
        public string TableProviders { get; set; } = "Providers";
        public Form1()
        {

            Id_DB = this.CompanyName;
            StringConect = $"Data Source=LAPTOP-046QU23H\\SQLEXPRESS;Initial Catalog={Id_DB};Integrated Security=True;";
            Connect = new SqlConnection(StringConect);

            InitializeComponent();
            SetDatabaseQueries();
            CreateDbIfNot();
        }

        private void CreateDbIfNot()
        {
            string StringConectServer = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Integrated Security=True;";
            SqlConnection ConnectServer = new SqlConnection(StringConectServer);

            ConnectServer.Open();

            string createDb = $"If(db_id(N'{Id_DB}') IS NULL) CREATE DATABASE[{Id_DB}]";
            SqlCommand Command = new SqlCommand(createDb, ConnectServer);
            Command.ExecuteNonQuery();

            CreateTableProductsIfNot();
            CreateTableTypesIfNot();
            CreateTableProvidersIfNot();

            ConnectServer.Close();
        }

        private void CreateTableProvidersIfNot()
        {/*
            
             USE [ProductStorage]
GO
*//****** Object:  Table [dbo].[Providers]    Script Date: 06.05.2021 22:08:19 ******//*
            SET ANSI_NULLS ON
            GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Providers](

   [id][int] IDENTITY(1, 1) NOT NULL,

   [Name] [nvarchar](50) NOT NULL,
CONSTRAINT[PK_Providers] PRIMARY KEY CLUSTERED
(

  [id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]
GO

            */
            throw new NotImplementedException();
        }

        private void CreateTableTypesIfNot()
        {
/*
            USE[ProductStorage]
GO
*//****** Object:  Table [dbo].[Types]    Script Date: 06.05.2021 22:09:57 ******//*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Types](

    [id][int] IDENTITY(1, 1) NOT NULL,

    [name] [nvarchar](50) NOT NULL,
 CONSTRAINT[PK_Types] PRIMARY KEY CLUSTERED
(

   [id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]
GO
*/

            throw new NotImplementedException();
        }

        private void CreateTableProductsIfNot()
        {
            /*
                        USE[ProductStorage]
            GO
            *//****** Object:  Table [dbo].[Products]    Script Date: 06.05.2021 22:04:54 ******//*
            SET ANSI_NULLS ON
            GO
            SET QUOTED_IDENTIFIER ON
            GO
            CREATE TABLE[dbo].[Products](

                [id][int] IDENTITY(1, 1) NOT NULL,

                [Name] [nvarchar](50) NOT NULL,

                [ProviderId] [int] NOT NULL,

                [Count] [int] NOT NULL,

                [DateProvide] [datetime2](7) NULL,
                [Price] [decimal](18, 2) NULL,
                [TypeId] [int] NULL,
             CONSTRAINT[PK_Products] PRIMARY KEY CLUSTERED
            (

               [id] ASC
            )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
            ) ON[PRIMARY]
            GO
            ALTER TABLE[dbo].[Products]  WITH CHECK ADD CONSTRAINT[FK_Products_Providers] FOREIGN KEY([ProviderId])
            REFERENCES[dbo].[Providers]([id])
            GO
            ALTER TABLE[dbo].[Products] CHECK CONSTRAINT[FK_Products_Providers]
            GO
            ALTER TABLE[dbo].[Products]  WITH CHECK ADD CONSTRAINT[FK_Products_Types] FOREIGN KEY([TypeId])
            REFERENCES[dbo].[Types]([id])
            GO
            ALTER TABLE[dbo].[Products] CHECK CONSTRAINT[FK_Products_Types]
            GO
            */
            throw new NotImplementedException();
        }

        private void SetDatabaseQueries()
        {
            /*
    ■ Отображение всей информации о товаре;
    ■ Отображение всех типов товаров;
    ■ Отображение всех поставщиков;
    ■ Показать товар с максимальным количеством;
    ■ Показать товар с минимальным количеством;
    ■ Показать товар с минимальной себестоимостью;
    ■ Показать товар с максимальной себестоимостью.
    ■ Показать товары, заданной категории;
    ■ Показать товары, заданного поставщика;
    ■ Показать самый старый товар на складе;
    ■ Показать среднее количество товаров по каждому типу товара.
             */


            //
            string fromProducts = " from Products ";
            string fromTypes = " from Types ";
            string fromProviders = " from Providers ";
            databaseQueries = new DatabaseQueries[]{
                new DatabaseQueries("■ Отображение всей информации о товаре;", $"select * {fromProducts} "),
                new DatabaseQueries("■ Отображение всех типов товаров;", $"select DISTINCT name {fromTypes}"),

                new DatabaseQueries("■ Отображение всех поставщиков;", $"select DISTINCT Name {fromProviders}"),
                new DatabaseQueries("■ Показать товар с максимальным количеством;", $"select * {fromProducts} WHERE Count = ( select  MAX(Count)  {fromProducts} )"),
                new DatabaseQueries("■ Показать товар с минимальным количеством;", $"select * {fromProducts} WHERE Count = ( select  MIN(Count)  {fromProducts} )"),
                new DatabaseQueries("■ Показать товар с минимальной себестоимостью;", $"select * {fromProducts} WHERE Price = ( select  MIN(Price)  {fromProducts} )"),
                new DatabaseQueries("■ Показать товар с максимальной себестоимостью.", $"select * {fromProducts} WHERE Price = ( select  MAX(Price)  {fromProducts} )"),

                new DatabaseQueries("■ Показать товары, заданной категории по названию типа;", $"select * {fromProducts},Types WHERE Types.id = Products.Typeid AND Types.name = @TypeName", new SqlParameter[] { new SqlParameter("@TypeName", SqlDbType.NVarChar) }),
                new DatabaseQueries("■ Показать товары, заданной категории по ID;", $"select * {fromProducts} WHERE Typeid = @TypeId", new SqlParameter[] { new SqlParameter("@TypeId", SqlDbType.Int) }),

                new DatabaseQueries("■ Показать товары, заданного поставщика;", $"select * {fromProducts} WHERE ProviderId = ( select id {fromProviders}  WHERE Name = @Name1)", new SqlParameter[] { new SqlParameter("@Name1", SqlDbType.NVarChar) }),
                new DatabaseQueries("■ Показать самый старый товар на складе;",  $"select * {fromProducts} WHERE DateProvide = ( select  MIN(DateProvide)  {fromProducts} )"),
                new DatabaseQueries("■ Показать среднее количество товаров по каждому типу товара.", $"select Distinct Type,AVG(Count)  {fromProducts} GROUP BY Type ")

            };
            foreach (var item in databaseQueries)
            {
                comboBoxQueries.Items.Add(item.ToString());
            }
        }

        private void checkBoxOnDB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnDB.Checked == true)
            {
                try
                {
                    Connect.Open();
                    DatabaseState.Text = "Подключение! Ок";
                    MessageBox.Show("Подключение!", "Ок");
                }
                catch
                {
                    checkBoxOnDB.Checked = false;
                    MessageBox.Show("Нет связи с БД!", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DatabaseState.Text = "Нет связи с БД! Ошибка подключения";
                }
            }
            if (checkBoxOnDB.Checked == false)
            {
                Connect.Close();
                DatabaseState.Text = "отключение";
            }
        }

        private void comboBoxQueries_SelectedIndexChanged(object c, EventArgs e)
        {

            int index = comboBoxQueries.SelectedIndex;
            var q = databaseQueries[index];

            //++++++++++++++++++

            if (Connect.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(q.Queri, Connect);

                if (q.sqlParameters != null)
                {

                    if (q.sqlParameters[0].SqlDbType == SqlDbType.NVarChar)
                    {

                        FormInputStringParameter FormDialog = new FormInputStringParameter();

                        FormDialog.ShowDialog();

                        q.sqlParameters[0].Value = FormDialog.GetParam();
                        command.Parameters.AddWithValue(q.sqlParameters[0].ParameterName, q.sqlParameters[0].Value);

                    }
                    if (q.sqlParameters[0].SqlDbType == SqlDbType.Int)
                    {

                        FormInputStringParameter FormDialog = new FormInputStringParameter();

                        FormDialog.ShowDialog();
                      
                        if (!int.TryParse((string)FormDialog.GetParam(), out int result))
                        {
                            MessageBox.Show($"Введено не число, по умолчанию присвоено {result}");
                        }
                       
                        q.sqlParameters[0].Value = result;

                        command.Parameters.AddWithValue(q.sqlParameters[0].ParameterName, q.sqlParameters[0].Value);

                    }
                }





                SqlDataReader sqlDataReader = command.ExecuteReader();


                dataGridView1.Columns.Clear();

                foreach (var item in sqlDataReader.GetColumnSchema())
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }


                while (sqlDataReader.Read()) // построчно считываем данные
                {

                    int readCount = sqlDataReader.GetColumnSchema().Count;
                    List<object> row = new List<object>();
                    for (int i = 0; i < readCount; i++)
                    {
                        row.Add(sqlDataReader[i]);
                    }

                    dataGridView1.Rows.Add(row.ToArray());

                }

                sqlDataReader.Close();

            }
            else
            {
                DatabaseState.Text = "База данных отключена, пожалуйста подключитесь.";
                MessageBox.Show("Нет связи с БД!", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //-----------------------


        }
    }
}
