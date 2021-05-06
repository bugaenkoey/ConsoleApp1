using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProductStorage
{
    public partial class FormInputStringParameter : Form
    {
      
        public FormInputStringParameter()
        {
            InitializeComponent();
        }


        internal object GetParam()
        {
            return textBox.Text;
        }
    }
}
