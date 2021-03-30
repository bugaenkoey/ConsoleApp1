using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VegetablesAndFruits
{
    public partial class FormInputParameter : Form
    {
       /* public string p1;
        public string p2;*/
        public System.Data.SqlClient.SqlParameter[] sqlParameters;
        public FormInputParameter(System.Data.SqlClient.SqlParameter[] @params)
        {
            InitializeComponent();
            sqlParameters = @params;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
         /*   p1 = textBox1.ToString();
            p2 = textBox2.ToString();*/
            sqlParameters[0].Value = int.Parse(textBox1.Text);
            sqlParameters[1].Value = int.Parse(textBox2.Text);
            Close();
        }
    }
}
