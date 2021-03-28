using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VegetablesAndFruits
{

    public partial class Form1 : Form
    {

        private DbConnection dbConnection = null;
        public SqlDataReader sqlDataReader = null;
        public SqlCommand sqlCommand = new SqlCommand();
        public SelectVF[] selectesVF;
        public int calLow;

        public enum TypeProduct
        {
            Fruits,
            Vegetable
        }
        public enum ColorProduct
        {
            Red = 1,
            Orange,
            Yellow,
            Green,
            Blue,
            White,
            Brown,
            Pink,
            Gray,
            Black,
            _
        }

        public Form1()
        {
            InitializeComponent();
            selectesVF = GetArraySelect2();

            foreach (var item in selectesVF)
            {
                comboBox1.Items.Add(item.Text);
            };
            var connectionString = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
            // connectionString = @"Data xxx;";
            // dbConnection.ConnectionString = connectionString;
            dbConnection = new SqlConnection(connectionString);

            AddComboBoxParam1();

        }
        public void AddComboBoxParam1()
        {

            for (int i = 1; i < (int)ColorProduct._; i++)
            {
                comboBoxParam1.Items.Add(((ColorProduct)i).ToString());
            }

        }
        private SelectVF[] GetArraySelect2()
        {
            SqlParameter parameter = new SqlParameter();
            string from = " from Products ";
            return new SelectVF[] {
                new SelectVF("■ Отображение всей информации из таблицы с овощами и фруктами;", $"select * {from} "),
                new SelectVF("■ Отображение всех названий овощей и фруктов;", $"select DISTINCT Name {from} "),
                new SelectVF("■ Отображение всех цветов;", $"select DISTINCT Color AS 'Color' {from} "),
                new SelectVF("■ Показать максимальную калорийность;", $"SELECT MAX (Cal) AS 'MaxCal' {from} "),
                new SelectVF("■ Показать минимальную калорийность;", $"SELECT MIN (Cal) AS 'MinCal' {from} "),
                new SelectVF("■ Показать среднюю калорийность.", $"SELECT AVG(Cal) AS 'AvgCal' {from} "),
                new SelectVF("■ Показать количество овощей;", $"SELECT COUNT(Type) AS 'Type' {from} WHERE Type = @typeV",new SqlParameter[] { new SqlParameter("@typeV", SqlDbType.Int) }),
                new SelectVF("■ Показать количество фруктов;", $"SELECT COUNT(Type) AS 'Type' {from} WHERE Type = @typeF",new SqlParameter[] { new SqlParameter("@typeF", SqlDbType.Int) }),
                new SelectVF("■ Показать количество овощей и фруктов заданного цвета;", $"SELECT COUNT(Type) AS 'Type' {from} WHERE Color = @color",new SqlParameter[] { new SqlParameter("@color", SqlDbType.Int) }),
                new SelectVF("■ Показать количество овощей фруктов каждого цвета;", $"SELECT COUNT(DISTINCT Color) AS 'Color'{from} "),//===== 
                new SelectVF("■ Показать овощи и фрукты с калорийностью ниже указанной;", $"SELECT * {from} WHERE Cal < @cal1", new SqlParameter[] { new SqlParameter("@cal1", SqlDbType.Int) }),
                new SelectVF("■ Показать овощи и фрукты с калорийностью выше указанной;", $"SELECT *  {from} WHERE Cal > @cal2", new SqlParameter[] { new SqlParameter("@cal2", SqlDbType.Int) }),
                new SelectVF("■ Показать овощи и фрукты с калорийностью в указанном диапазоне;", $"SELECT * {from} WHERE Cal BETWEEN @cal1 AND @Cal2", new SqlParameter[] { new SqlParameter("@cal1", SqlDbType.Int), new SqlParameter("@cal2", SqlDbType.Int) }),
                new SelectVF("■ Показать все овощи и фрукты, у которых цвет желтый или красный.", $"SELECT * {from} WHERE Color =  @color1 OR Color = @color2", new SqlParameter[] { new SqlParameter("@color1", SqlDbType.Int), new SqlParameter("@color2", SqlDbType.Int) })

            };
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;

            var selectSQL = selectesVF[index].Select;
            var text = selectesVF[index].Text;

            textBoxShowSelect.Text = text;

            if (dbConnection.State == ConnectionState.Open)
            {
                //  ShowSelect(selectSQL);
                //++++

                if (selectesVF[index].Params != null)
                {

                    textBoxValue1.Visible = true;
                    // textBoxValue1.Text = "parameter";///////////////////////////////


                    //  ShowSelect(selectSQL, selectesVF[index].Params);
                }
                else
                {
                    textBoxValue1.Visible = false;
                    textBoxValue1.Text = string.Empty;
                    //  ShowSelect(selectSQL);//----------------------------
                }



                ShowSelect(selectSQL, selectesVF[index].Params);
                //----
            }
            else
            {
                textBoxShowSelect.Text = "База данных отключена, пожалуйста подключитесь.";
                MessageBox.Show("Нет связи с БД!", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void checkBoxDbConnect_CheckedChanged(object sender, EventArgs e)
        {
            textBoxShowSelect.Text = string.Empty;
            if (checkBoxDbConnect.Checked == true)
            {
                try
                {
                    dbConnection.Open();
                    labelDbConnect.Text = "Подключение! Ок";
                    MessageBox.Show("Подключение!", "Ок");
                    comboBox1.SelectedIndex = 0;
                    // ShowSelect("select * from VegetablesAndFruits");
                    //                   InsertInDb();//+++++++++++++++++++++++++++++++++++++++++++++++++++
                }
                catch
                {
                    checkBoxDbConnect.Checked = false;
                    MessageBox.Show("Нет связи с БД!", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelDbConnect.Text = "Нет связи с БД! Ошибка подключения";
                }
            }
            if (checkBoxDbConnect.Checked == false)
            {

                dbConnection.Close();
                labelDbConnect.Text = "отключение";
                textBoxShowSelect.Text = string.Empty;
            }

        }

        private void ShowSelect(string select, SqlParameter[] sqlParameters)
        {
            sqlCommand = new SqlCommand(select, (SqlConnection)dbConnection);

            if (sqlParameters != null)
            {
                for (int i = 0; i < sqlParameters.Length; i++)
                {


                    sqlCommand.Parameters.AddWithValue(sqlParameters[i].ParameterName, 1);
                }
            }

            sqlDataReader = sqlCommand.ExecuteReader();  //?????????????????????????

            // dataGridView1.Columns.AddRange(new DataGridViewColumn[sqlDataReader.FieldCount] );


            ReadData(ref sqlDataReader);
            sqlDataReader.Close();

        }

        private void ReadData(ref SqlDataReader sqlDataReader)
        {
            dataGridView1.Columns.Clear();

            foreach (var item in sqlDataReader.GetColumnSchema())
            {
                dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
            }



            //  List<string[]> data = new List<string[]>();
            List<List<string>> dataData = new List<List<string>>();


            List<string[]> data2 = new List<string[]>();
            while (sqlDataReader.Read())
            {
                data2.Add(new string[sqlDataReader.GetColumnSchema().Count]);

                for (int i = 0; i < sqlDataReader.GetColumnSchema().Count; i++)
                {
                    if (sqlDataReader.GetColumnSchema()[i].ColumnName == "Type")
                    {

                        if (int.TryParse(sqlDataReader[i].ToString(), out int resultTypeProduct))
                        {
                            data2[data2.Count - 1][i] = ((TypeProduct)resultTypeProduct).ToString();

                        }
                    }
                    else if (sqlDataReader.GetColumnSchema()[i].ColumnName == "Color")
                    {

                        if (int.TryParse(sqlDataReader[i].ToString(), out int resultTypeProduct))
                        {
                            data2[data2.Count - 1][i] = ((ColorProduct)resultTypeProduct).ToString();

                        }

                    }
                    else
                    {
                        data2[data2.Count - 1][i] = sqlDataReader[i].ToString();

                    }
                }
            }
                foreach (string[] s in data2)
                {
                    dataGridView1.Rows.Add(s);
                }
                // return;
                ///////////////////////////////////

                /*  List<string> data = new List<string>();

                  for (int i = 0; i < sqlDataReader.FieldCount; i++)
                  {

                      data.Add(sqlDataReader[i].ToString());
                  }

                  dataData.Add(data);*/



                //////////
                /*  data[data.Count - 1][0] = sqlDataReader[0].ToString();
                  data[data.Count - 1][1] = sqlDataReader[1].ToString();

                  //   var tp= (TypeProduct)sqlDataReader[2];

                  data[data.Count - 1][2] = ((TypeProduct)sqlDataReader[2]).ToString();

                  data[data.Count - 1][3] = ((ColorProduct)sqlDataReader[3]).ToString();
                  data[data.Count - 1][4] = sqlDataReader[4].ToString();

                  for (int i = 0; i < sqlDataReader.FieldCount; i++)
                  {
                      textBoxShowSelect.Text += " " + sqlDataReader[i] + " ";

                  }
                  textBoxShowSelect.Text += " -*- ";*/
          //  }

            //  dataGridView1 = new DataGridView();
            //      var gCS = sqlDataReader.GetColumnSchema();
            /*   int j = default;
               dataGridView1.Columns.Clear();
               int ProductTypeIndexColum = default;
               int ColorIndexColum = default;*/

            /*   foreach (var item in sqlDataReader.GetColumnSchema())
               {
                   // dataGridView1.Columns.Contains.text
                   //  item.ColumnName
                   if (item.ColumnName == "Type")
                   {
                       ProductTypeIndexColum = j;
                   }

                   if (item.ColumnName == "Color")
                   {
                       ColorIndexColum = j;
                   }

                   dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                   //  dataGridView1.Columns[j].Name = item.ColumnName;
                   // dataGridView1.Columns.AddRange(item);
                   j++;
               }
   */
            /*   dataGridView1.Rows.Clear();
               // var data_Data = dataData.ToArray();
               //  foreach (var item in dataData.ToArray())
               for (int ii = 0; ii < dataData.ToArray().Length; ii++)
               {
                   //   var data_Data_I = dataData[i].ToArray();

                   for (int jj = 0; jj < dataData[ii].ToArray().Length; jj++)
                   {

                       if (int.TryParse(dataData[ii][jj], out int resultTypeProduct))
                       {
                           dataData[ii][jj] = ((TypeProduct)resultTypeProduct).ToString();
                       }

                       if (int.TryParse(dataData[ii][jj], out int resultColorProduct))
                       {
                           dataData[ii][jj] = ((ColorProduct)resultColorProduct).ToString();
                       }

                       *//*
                                           if (*//*ProductTypeIndexColum >0 &&*//* jj == ProductTypeIndexColum)
                                           {


                                               int tp = int.Parse(dataData[ii][jj]);

                                               dataData[ii][jj] = ((TypeProduct)tp).ToString();
                                           }
                                           if (*//*ColorIndexColum>0 &&*//* jj == ColorIndexColum)
                                           {

                                               int cp = int.Parse(dataData[ii][jj]);
                                               dataData[ii][jj] = ((ColorProduct)cp).ToString();
                                           }
                                           //  else
                                           {
                                               // dataGridView1.Rows.Add(dataData[ii].ToArray());
                                           }*//*
                   }
                   dataGridView1.Rows.Add(dataData[ii].ToArray());
               }*/
            /*  foreach (string[] s in data)
              {
                  dataGridView1.Rows.Add(s);
              }*/

        }
        /*   private void ReadData()
           {
               List<string[]> data = new List<string[]>();
               //  List<List<string[]>>dataData = new List<List<string[]>>();
               while (sqlDataReader.Read())
               {
                   data.Add(new string[5]);

                   data[data.Count - 1][0] = sqlDataReader[0].ToString();
                   data[data.Count - 1][1] = sqlDataReader[1].ToString();

                   //   var tp= (TypeProduct)sqlDataReader[2];

                   data[data.Count - 1][2] = ((TypeProduct)sqlDataReader[2]).ToString();

                   data[data.Count - 1][3] = ((ColorProduct)sqlDataReader[3]).ToString();
                   data[data.Count - 1][4] = sqlDataReader[4].ToString();

                   for (int i = 0; i < sqlDataReader.FieldCount; i++)
                   {
                       textBoxShowSelect.Text += " " + sqlDataReader[i] + " ";

                   }
                   textBoxShowSelect.Text += " -*- ";
               }
               sqlDataReader.Close();
               foreach (string[] s in data)
               {
                   dataGridView1.Rows.Add(s);
               }
           }*/

        public void InsertInDb()
        {
            //  sqlCommand = new SqlCommand(select, (SqlConnection)dbConnection);
            string insertString = @"insert into Products (Name, Type, Color,Cal) values ('Огурец', '1','4','220')";
            //создать объект command, инициализировав оба свойства
            SqlCommand cmd = new SqlCommand(insertString, (SqlConnection)dbConnection);
            //выполнить запрос, занесенный в объект command
            cmd.ExecuteNonQuery();
        }

        private void textBoxValue1_TextChanged(object sender, EventArgs e)
        {
            calLow = GetParamTextBox();

        }

        private void textBoxValue2_TextChanged(object sender, EventArgs e)
        {

        }
        public int GetParamTextBox()
        {
            if (int.TryParse(textBoxValue1.Text, out int result))
            {
                return result;
            }
            else
            {
                return 0;
                // textBoxValue1.Text = $"Введено не число, по умолчанию присвоено {result}";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
