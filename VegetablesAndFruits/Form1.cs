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
        public Form1()
        {
            InitializeComponent();
            var connectionString = @"Data Source=LAPTOP-046QU23H\SQLEXPRESS;Initial Catalog=VegetablesFruits;Integrated Security=True;";
            // connectionString = @"Data xxx;";
            // dbConnection.ConnectionString = connectionString;
            dbConnection = new SqlConnection(connectionString);
        }
        public void ConnectOpenDb()
        {

        }


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
            }
            
        }

        private void ShowSelect()
        {
            textBoxShowSelect.Text = "";
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("select * from VegetablesAndFruits", (SqlConnection)dbConnection);
            rdr = cmd.ExecuteReader();
            textBoxShowSelect.Text = string.Empty;

            while (rdr.Read())
            {
              //  textBoxShowSelect.Text = string.Empty;
                textBoxShowSelect.Text += (rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + "\t");
                textBoxShowSelect.Text += "\n";
            }
        }
    }
}
