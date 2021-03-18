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

namespace VegetablesAndFruits
{

    public partial class Form1 : Form
    {

        private DbConnection dbConnection = null;
        // public List<SelecteVF> selectesVF;
        public SelectVF[] selectesVF;
        public Form1()
        {
            InitializeComponent();
            selectesVF = GetArraySelect();
            
                foreach (var item in selectesVF)
                {
                    comboBox1.Items.Add( item.Text);
                } ;
            var connectionString = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
            // connectionString = @"Data xxx;";
            // dbConnection.ConnectionString = connectionString;
            dbConnection = new SqlConnection(connectionString);
        }

        private SelectVF[] GetArraySelect()
        {
            string from = " from VegetablesAndFruits ";
            return new SelectVF[]  {
             new SelectVF("■ Отображение всей информации из таблицы с овощами и фруктами;",$"select * {from} "),
             new SelectVF("■ Отображение всех названий овощей и фруктов;",$"select Название {from} "),
             new SelectVF("■ Отображение всех цветов;",$"select Цвет {from} "),
             new SelectVF("■ Показать максимальную калорийность;",$"SELECT MAX (калорийность) {from} "),
             new SelectVF("■ Показать минимальную калорийность;",$"SELECT MIN (калорийность) {from} "),
             new SelectVF("■ Показать среднюю калорийность.",$"SELECT AVG(калорийность) {from} "),
             new SelectVF("■ Показать количество овощей;",$"SELECT COUNT(Тип) {from} WHERE Тип = 0"),
             new SelectVF("■ Показать количество фруктов;",$"SELECT COUNT(Тип) {from} WHERE Тип = 1"),
             new SelectVF("■ Показать количество овощей и фруктов заданного цвета;",$"SELECT COUNT(Тип) {from} WHERE Цвет = 'k'"),
             new SelectVF("■ Показать количество овощей фруктов каждого цвета;",$"SELECT COUNT(DISTINCT Цвет) {from} "),//===== 
             new SelectVF("■ Показать овощи и фрукты с калорийностью ниже указанной;",$"SELECT * {from} WHERE калорийность < 150 AND Тип = 1"),
             new SelectVF("■ Показать овощи и фрукты с калорийностью выше указанной;",$"SELECT * {from} WHERE калорийность > 150 AND Тип = 1"),
             new SelectVF("■ Показать овощи и фрукты с калорийностью в указанном диапазоне;",$"SELECT * {from} WHERE калорийность BETWEEN 100 AND 150 AND Тип = 1"),
             new SelectVF("■ Показать все овощи и фрукты, у которых цвет желтый или красный.",$"SELECT * {from} WHERE Цвет =  'k' OR Цвет = 'y'")
            };

        }

    /*    private List<SelecteVF> GetListSelect()
        {
           //  string select = "select * from VegetablesAndFruits";
            return new List<SelecteVF>
           {
             new SelecteVF("■ Отображение всей информации из таблицы с овощами и фруктами;","select * from VegetablesAndFruits"),
             new SelecteVF("■ Отображение всех названий овощей и фруктов;",""),
             new SelecteVF("■ Отображение всех цветов;",""),
             new SelecteVF("■ Показать максимальную калорийность;",""),
             new SelecteVF("■ Показать минимальную калорийность;",""),
             new SelecteVF("■ Показать среднюю калорийность.",""),
             new SelecteVF("■ Показать количество овощей;",""),
             new SelecteVF("■ Показать количество фруктов;",""),
             new SelecteVF("■ Показать количество овощей и фруктов заданного цвета;",""),
             new SelecteVF("■ Показать количество овощей фруктов каждого цвета;",""),
             new SelecteVF("■ Показать овощи и фрукты с калорийностью ниже указанной;",""),
             new SelecteVF("■ Показать овощи и фрукты с калорийностью выше указанной;",""),
             new SelecteVF("■ Показать овощи и фрукты с калорийностью в указанном диапазоне;",""),
             new SelecteVF("■ Показать все овощи и фрукты, у которых цвет желтый или красный.","")
            };


        }
*/
        private void checkBoxDbConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDbConnect.Checked == true)
            {
                try
                {
                    //   dbConnection = new SqlConnection(connectionString);
                    dbConnection.Open();
                    //  checkBoxDbConnect.Checked = true;
                    labelDbConnect.Text = "Подключение! Ок";
                    MessageBox.Show("Подключение!", "Ок");
                    ShowSelect();

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
                labelDbConnect.Text = "одключение";
                textBoxShowSelect.Text = string.Empty;
            }

        }

        private void ShowSelect()
        {
            dbConnection.Open();
            //  textBoxShowSelect.Text = string.Empty;
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("select * from VegetablesAndFruits", (SqlConnection)dbConnection);
            rdr = cmd.ExecuteReader();
            textBoxShowSelect.Text = string.Empty;

            while (rdr.Read())
            {
                textBoxShowSelect.Text += (rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + "\t");
                textBoxShowSelect.Text += "\n";
            }
            dbConnection.Close();
        }
        private void ShowSelect(string select)
        {
            dbConnection.Open();
            //  textBoxShowSelect.Text = string.Empty;
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand(select, (SqlConnection)dbConnection);
            rdr = cmd.ExecuteReader();
           // textBoxShowSelect.Text = string.Empty;

            while (rdr.Read())
            {
                // textBoxShowSelect.Text += (rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + "\t");
              //  textBoxShowSelect.Text += " FieldCount " + rdr.FieldCount;
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    textBoxShowSelect.Text += " " + rdr[i] + " ";
                }
              //  textBoxShowSelect.Text += " "+rdr[0]+" ";
               // textBoxShowSelect.Text += "\n";
            }
            dbConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;
            var selectSQL = selectesVF[index].Select;
            var text = selectesVF[index].Text;
            textBoxShowSelect.Text = text;
            ShowSelect(selectSQL);
            /*
             var index = comboBox1.SelectedIndex;
             var itemText = comboBox1.GetItemText(comboBox1.SelectedItem);
             textBoxShowSelect.Text = string.Empty;
             textBoxShowSelect.Text = $"index {index} {itemText}";
            */


            //■ Отображение всей информации из таблицы с овощами и фруктами;
            //■ Отображение всех названий овощей и фруктов;
            //■ Отображение всех цветов;
            //■ Показать максимальную калорийность;
            //■ Показать минимальную калорийность;
            //■ Показать среднюю калорийность.
            //■ Показать количество овощей;
            //■ Показать количество фруктов;
            //■ Показать количество овощей и фруктов заданного цвета;
            //■ Показать количество овощей фруктов каждого цвета;
            //■ Показать овощи и фрукты с калорийностью ниже указанной;
            //■ Показать овощи и фрукты с калорийностью выше указанной;
            //■ Показать овощи и фрукты с калорийностью в указанном диапазоне;
            //■ Показать все овощи и фрукты, у которых цвет желтый или красный.

        }
    }
}
