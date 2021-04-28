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
        // private DbConnection Connect = null;
        public SqlDataReader sqlDataReader = null;
        public SqlCommand sqlCommand = new SqlCommand();
        public string StringConect { get; set; }
        public SqlConnection Connect = null;
        public string Id_DB { get; set; } = "";
        private DatabaseQueries[] databaseQueries = null;
        // public Database database;
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
            SqlConnection Connect = new SqlConnection(StringConectServer);

            Connect.Open();

            string insertString = $"If(db_id(N'{Id_DB}') IS NULL) CREATE DATABASE[{Id_DB}]";
            SqlCommand cmd = new SqlCommand(insertString, Connect);
            cmd.ExecuteNonQuery();
            Connect.Close();
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
            string fromProviders = " from Providers ";
            databaseQueries = new DatabaseQueries[]{
                new DatabaseQueries("■ Отображение всей информации о товаре;", $"select * {fromProducts} "),
                new DatabaseQueries("■ Отображение всех типов товаров;", $"select DISTINCT Type {fromProducts}"),
                new DatabaseQueries("■ Отображение всех поставщиков;", $"select DISTINCT Name {fromProviders}"),
                new DatabaseQueries("■ Показать товар с максимальным количеством;", $"select * {fromProducts} WHERE Count = ( select  MAX(Count)  {fromProducts} )"),
                new DatabaseQueries("■ Показать товар с минимальным количеством;", $"select * {fromProducts} WHERE Count = ( select  MIN(Count)  {fromProducts} )"),
                new DatabaseQueries("■ Показать товар с минимальной себестоимостью;", $"select * {fromProducts} WHERE Price = ( select  MIN(Price)  {fromProducts} )"),
                new DatabaseQueries("■ Показать товар с максимальной себестоимостью.", $"select * {fromProducts} WHERE Price = ( select  MAX(Price)  {fromProducts} )"),

                new DatabaseQueries("■ Показать товары, заданной категории;", $"select * {fromProducts} WHERE Type ='Type1'", new SqlParameter[] { new SqlParameter("", SqlDbType.Int) }),
                new DatabaseQueries("■ Показать товары, заданного поставщика;", $"select * {fromProducts} WHERE ProviderId = 1", new SqlParameter[] { new SqlParameter("", SqlDbType.Int) }),
                new DatabaseQueries("■ Показать самый старый товар на складе;",  $"select * {fromProducts} WHERE DateProvide = ( select  MIN(DateProvide)  {fromProducts} )"),
                new DatabaseQueries("■ Показать среднее количество товаров по каждому типу товара.", $"select * {fromProducts} WHERE Count = ( select  AVG(Count)  {fromProducts} )")

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

                if (databaseQueries[index].sqlParameters != null)
                {

                    //  DialogForm(selectesVF[index].Params);
                    FormInputParameter FormDialog = new FormInputParameter(databaseQueries[index].sqlParameters);

                    FormDialog.ShowDialog();

                }
              

              //  ShowSelect(q.queri, databaseQueries[index].sqlParameters);

            SqlCommand command = new SqlCommand(q.queri, Connect);



            SqlDataReader sqlDataReader = command.ExecuteReader();
            var schema = sqlDataReader.GetColumnSchema();


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
