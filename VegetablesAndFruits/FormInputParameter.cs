using System;
using System.Windows.Forms;

namespace VegetablesAndFruits
{
    public partial class FormInputParameter : Form
    {
       
        public System.Data.SqlClient.SqlParameter[] sqlParameters;
        public FormInputParameter(System.Data.SqlClient.SqlParameter[] @params)
        {
            InitializeComponent();
            sqlParameters = @params;
            labelParam2.Visible = @params.Length > 1 ? true : false;
            textBox2.Visible = @params.Length > 1 ? true : false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
         

            if (int.TryParse(textBox2.Text, out int result2))
            {
                sqlParameters[1].Value = result2;

            }
            else
            {
                MessageBox.Show("Введено не число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.TryParse(textBox1.Text, out int result1))
            {
                sqlParameters[0].Value = result1;
            }
            else
            {
                MessageBox.Show("Введено не число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
           // sqlParameters[0].Value = int.Parse(textBox1.Text);
           // sqlParameters[1].Value = int.Parse(textBox2.Text);

          //  Close();
        }
    }
}
